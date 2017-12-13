using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShipController : MonoBehaviour
{
    public float Acceleration; //Modifier for ship acceleration
    public float TurningRate; //Modifier for ship turning rate
    public GameObject PlayerBullet;
    public float MaxSpeed;
    public Texture2D Cursor;
    public bool customcursorenabled;


    private Rigidbody2D rigidbodyPlayer;
    private float Speed; 

    public AudioClip Shoot;
    public AudioClip PlayerDestroyed;

    // Use this for initialization
    void Start()
    {
        rigidbodyPlayer = this.GetComponent<Rigidbody2D>();
        
    }

    void FixedUpdate()
    {
        //Get inputs for forward/back
        float horizontal = -Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Speed of ship is set by holding up/down axis. Once set, the velocity will remain constant.
        Speed += vertical * Acceleration;
        rigidbodyPlayer.velocity = transform.up * Speed;

        //************WONDERCODE STARTS HERE (HANDLES CAR LIKE MOVEMENT**********

        //the velocity of the ship towards +y = absolute velocity * Speed 

        if (rigidbodyPlayer.velocity.magnitude > 0)
        {
            //rigidbody.velocity = transform.up * Speed;
            transform.up = rigidbodyPlayer.velocity * Speed;
        }
        //************WONDERCODE ENDS HERE***************************************


        rigidbodyPlayer.rotation += (horizontal * TurningRate); //rotation

        //Set speed limit
        if (rigidbodyPlayer.velocity.magnitude > MaxSpeed)//for large speeds
        {
            Speed = MaxSpeed -1;
        }
        if (Speed <= 0)//for backwards max speed
        {
            Speed = 0.01f; // due to "wondercode", if velocity is ever at zero, ship 
            //rotation will be set to +y. By having speed always be positive, original velocity vector DIRECTION
            //will always preserved.
        }



    }

    void OnGUI()
    {
        if (customcursorenabled)
        {
            GUI.DrawTexture(new Rect(Input.mousePosition.x - 79, -(Input.mousePosition.y) + 1000, Cursor.width, Cursor.height), Cursor);
        }
    }
}



