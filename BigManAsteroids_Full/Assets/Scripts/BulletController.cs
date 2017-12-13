using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public int Speed;
    public float BulletDecayTime;

    private Rigidbody2D rigid;

    // Use this for initialization
    void Start()
    {
        //set bullet to destroy itself after 1 seconds
        Destroy(gameObject, BulletDecayTime);

        //Push the bullet in the direction it is facing
        rigid = GetComponent<Rigidbody2D>();
        if (rigid != null)
        {
            rigid.AddForce(transform.up * 100 * Speed);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
