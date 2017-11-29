using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if  (
            (this.gameObject.tag == ("Blue") && collision.gameObject.tag == ("Blue")) ||
            (this.gameObject.tag == ("¨Red") && collision.gameObject.tag == ("Red"))
            )
        {
            Physics2D.IgnoreCollision(this, collision);
        }*/
        


        if  (
            (this.gameObject.tag == ("Blue") && collision.gameObject.tag == ("Red")) ||
            (this.gameObject.tag == ("¨Red") && collision.gameObject.tag == ("Blue"))
            )
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
