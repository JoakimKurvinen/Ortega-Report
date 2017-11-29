using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public int Speed;
    public float BulletDecayTime;

    // Use this for initialization
    void Start()
    {
        //set bullet to destroy itself after 1 seconds
        Destroy(gameObject, BulletDecayTime);


        //Push the bullet in the direction it is facing
        GetComponent<Rigidbody2D>().AddForce(transform.up * 100 * Speed);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
