using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// simple ai script for the tanker. check the AIfollow for more comments 
/// </summary>
public class AItanker : MonoBehaviour
{
    //decalare variables
    public float mSpeed; //movement speed
    public float rSpeed; //rotation speed min=0 max=1
    public float dRange; //detection range
    public float mRange; //range when to move
    public GameObject target; //set target in unity

    private Vector2 tDirection; //target's direction
    private Quaternion wDirection; // wanted direction
    private Rigidbody2D rigidbody;

    // Use this for initialization
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        
        tDirection = target.transform.position - transform.position;
        float deg = Mathf.Atan2(tDirection.y, tDirection.x) * Mathf.Rad2Deg; //converts from rad to deg
        wDirection = Quaternion.AngleAxis(deg - 90f, Vector3.forward); //gets the wanted direction
        transform.rotation = Quaternion.Slerp(transform.rotation, wDirection, rSpeed); //actually turns the ship

        if (Vector2.Distance(target.transform.position, transform.position) <= mRange)
        {
            //sets the ais velocity to be similar to the players movement style
            rigidbody.velocity = transform.up * mSpeed;
        }

    }
}