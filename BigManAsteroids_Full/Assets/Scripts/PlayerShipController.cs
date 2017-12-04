using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipController : MonoBehaviour
{
    public float Acceleration; //Modifier for ship acceleration
    public float TurningRate; //Modifier for ship turning rate
    public GameObject PlayerBullet;
    public float MaxSpeed;

    private Rigidbody2D rigidbody;
    private float Speed; 

    public AudioClip Shoot;
    public AudioClip PlayerDestroyed;

    // Use this for initialization
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //Get inputs for forward/back
        float horizontal = -Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Speed of ship is set by holding up/down axis. Once set, the velocity will remain constant.
        Speed += vertical * Acceleration;
        rigidbody.velocity = transform.up * Speed;

        //************WONDERCODE STARTS HERE (HANDLES CAR LIKE MOVEMENT**********

        //the velocity of the ship towards +y = absolute velocity * Speed 

        if (rigidbody.velocity.magnitude > 0)
        {
            //rigidbody.velocity = transform.up * Speed;
            transform.up = rigidbody.velocity * Speed;
        }
        //************WONDERCODE ENDS HERE***************************************


        rigidbody.rotation += (horizontal * TurningRate); //rotation

        //Set speed limit
        if (rigidbody.velocity.magnitude > MaxSpeed)//for large speeds
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
}



