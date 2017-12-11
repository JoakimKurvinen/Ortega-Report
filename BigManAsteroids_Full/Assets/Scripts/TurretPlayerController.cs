using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TurretPlayerController : MonoBehaviour
{

    public GameObject bullet; //the bullet that the turret shoots
    public GameObject AttachedShip; //gameobject that turret will be attached to

    public float Firerate;
    public float Radius; //how far away turret will be in relation to ship
    public float Phase; //which angle turret will be in relation to ship

    public Texture2D Cursor;

    private Vector3 PositionModifier; 
    private Vector3 UnitVec; //unitvector direction of offset
    private float shipangle;
    private float angle;

    private Vector3 mousePos; //position of mouse
    private Vector3 turretPos; //position of turret relative to screen
    private Vector3 targetPos; //vector of direction turret should point
    private Vector3 test;

    private bool shooting = false;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Shoot", 0, Firerate);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //TURRET POSITION
           
        shipangle = (Mathf.Asin(AttachedShip.transform.rotation.z))*(-2); //output of AttachedShip.transform.rotation.z is sinusoidal. (from 0 (at0/4), to 0.707(at1/4), to 1(at2/4)
        //must use ArcSin, and then multiply by 2 so that 2/4 gives 3.14 and can be directly inpu

        UnitVec = new Vector2(Mathf.Sin((shipangle + Phase)), Mathf.Cos((shipangle + Phase)));

        //Debug.Log(shipangle);

        PositionModifier = UnitVec * Radius; //offset of turrest in relation to ship is unitvector direction * magnitude (radius)

        test = AttachedShip.transform.position + PositionModifier; //position of turret = position of AttachedShip + offset
        test.z = AttachedShip.transform.position.z - 1;
        transform.position = test;
        /*Debug.Log("shipangle is:" + shipangle);
        Debug.Log("in radians:" + Mathf.Deg2Rad * (shipangle + Phase));*/
        
        //TURRET ROTATION

        mousePos = Input.mousePosition;//gets position of mouse cursor
        turretPos = Camera.main.WorldToScreenPoint(transform.position);//gets position of turret relative to screen

        targetPos.x = mousePos.x - turretPos.x;//creates targetPos vector, drawing from position of turret to mouse
        targetPos.y = mousePos.y - turretPos.y;

        angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;//for calculating angle of how much turret has to rotate so it is pointing towards mouse
        //print("turret at angle: " + angle);

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, (angle - 90f)));//rotates turret to specified angle (-90f to get in phase with cursor)
        
        if (shooting == false && (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space")))
        {
                shooting = true;
        }
        else if (shooting == true && (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space")))
        {
            shooting = false;
        }
       
        
        /*
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space"))
        {

            shooting = true;
            //GameObject obj = (GameObject)Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
            //obj.transform.Rotate(0, 0, Random.Range(-5, 5));

        }
        if (Input.GetMouseButtonUp(0))
        {
            shooting = false;
        }
        */
        
    }
    void Shoot()
    {
        if (!shooting) return;//checks if shooting is true or false

        GameObject obj = Instantiate(bullet, new Vector2(transform.position.x, transform.position.y), transform.rotation);
        //creates a new bullet based and gives it a vector to move along based on the scriptTargets position and rotation

        obj.transform.Rotate(0, 0, Random.Range(-7, 8));//adds a random rotate for the spawned bullets

    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Input.mousePosition.x, -(Input.mousePosition.y) + 350, Cursor.width, Cursor.height), Cursor);
    }
}
