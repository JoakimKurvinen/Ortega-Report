using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// simple turret ai which can shoot targets based on what is set.
/// Distance is checked to see if to start shooting and when to end shooting.
/// Ask Aleksi....
/// </summary>
public class LaserTurretAIController : MonoBehaviour
{
    //public GameObject target; //set target in unity
    public GameObject AttachedShip; //the thing the script is attached to
    public float aRange; //attack range
    public float Firerate; //interval in seconds between shots
    public string targetTag; //tag from which targets can be selected from
    public Material laserMat;
    public GameObject Laserfade;

    private GameObject target;
    private bool shooting = false; //sets shooting to false
    private bool running = false;

    public float Radius; //how far away turret will be in relation to ship
    public float Phase; //which angle turret will be in relation to ship

    private LineRenderer line;
    private bool laseron;
    private Vector3 PositionModifier;
    private Vector3 UnitVec; //unitvector direction of offset
    private float shipangle;
    private float angle;

    private Vector3 mousePos; //position of mouse
    private Vector3 turretPos; //position of turret relative to screen
    private Vector3 targetPos; //vector of direction turret should point

    // Use this for initialization
    void Start()
    {
        //InvokeRepeating("Shoot", 0, Firerate); // repets the mehod shoot based
        LineRenderer line = GetComponent<LineRenderer>();                           //on the repeat rate
        
    }

    // Update is called once per frame
    void Update()
    {
        //TURRET POSITION

        shipangle = -Mathf.Asin(AttachedShip.transform.rotation.z) * 2; //output of AttachedShip.transform.rotation.z is sinusoidal. (from 0 (at0/4), to 0.707(at1/4), to 1(at2/4)
        //must use ArcSin, and then multiply by 2 so that 2/4 gives 3.14 and can be directly inpu
        UnitVec = new Vector2(Mathf.Sin((shipangle + Phase)), Mathf.Cos((shipangle + Phase)));

        //Debug.Log(1.74533f * (-shipangle + Phase));

        PositionModifier = UnitVec * Radius; //offset of turrest in relation to ship is unitvector direction * magnitude (radius)

        transform.position = AttachedShip.transform.position + PositionModifier; //position of turret = position of AttachedShip + offset

        /*Debug.Log("shipangle is:" + shipangle);
        Debug.Log("in radians:" + Mathf.Deg2Rad * (shipangle + Phase));*/


        target = FindTarget(targetTag);

        //if (target != null)

        //{
            if (Vector2.Distance(target.transform.position, transform.position) <= aRange)
            {
                shooting = true; //if distance is less than attack range

                //TURRET ROTATION TOWARDS TARGET
                mousePos = target.transform.position;//gets position of target
                turretPos = transform.position;//gets position of turret relative to screen

                targetPos.x = mousePos.x - turretPos.x;//creates targetPos vector, drawing from position of turret to target
                targetPos.y = mousePos.y - turretPos.y;

                angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;//for calculating angle of how much turret has to rotate so it is pointing towards mouse
                                                                              //print("turret at angle: " + angle);

                transform.rotation = Quaternion.Euler(new Vector3(0, 0, (angle - 90f)));//rotates turret to specified angle (-90f to get in phase with cursor)
                Debug.Log("target found");
            }
        //}
        else
        {
            Debug.Log("target is null");
            shooting = false;
        }
        StartCoroutine(Shoot());
        RenderLine();
    }
    IEnumerator Shoot()
    {   
        
        if (shooting == true && running == false) //checks if shooting is true or is currently waiting after fireing
        {
            running = true;
            laseron = true;
            Instantiate(Laserfade, new Vector2(target.transform.position.x, target.transform.position.y), target.transform.rotation);

            yield return new WaitForSeconds(Firerate);
            
            laseron = false;
            running = false;
        }
        else
        {
            laseron = false;
        }
        
    }
    
    void RenderLine()
    {
        LineRenderer line = GetComponent<LineRenderer>();
        if (laseron == true)
        {
            line.enabled = true;
            line.positionCount = 2;
            line.startWidth = 0.1f;
            line.endWidth = 0.1f;
            if (target != null)
            {
                line.SetPosition(0, new Vector2(this.transform.position.x, this.transform.position.y));
                line.SetPosition(1, new Vector2(target.transform.position.x, target.transform.position.y));
            }
            Debug.Log("laseron");
        }
        else
            {
            line.enabled = false;
            Debug.Log("laseroff");
            }

        

        
    }
    GameObject FindTarget(string targetTag)
    {
        GameObject[] potTargets;
        List<float> potDistance = new List<float>();
        int IndexMin = 0;

        //PUTTING ALL POTENTIONAL TARGETS INTO LIST OF GAMEOBJECTS
        potTargets = GameObject.FindGameObjectsWithTag(targetTag);

        if (potTargets.Length == 0)
        {
            return null;
        }

        foreach (GameObject n in potTargets)//Checking for distance to each object
        {
            potDistance.Add((n.transform.position - transform.position).magnitude);
        }

        //FINDING SMALLEST DISTANCE VALUE

        for (int m = 0; m < potTargets.Length; m++)
        {
            if (potDistance[m] < potDistance[IndexMin])    //compare Min with every value,
            {
                IndexMin = m;   //if smaller value is found, set Min to smaller value
            }
        }
        return (potTargets[IndexMin]);
    }
}
