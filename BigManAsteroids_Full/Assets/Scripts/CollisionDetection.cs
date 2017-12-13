using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour {

    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if  (
                ((this.gameObject.tag == ("Blue")||this.gameObject.tag == ("BlueBullet")) && (collision.gameObject.tag == ("Red")||collision.gameObject.tag == ("RedBullet"))) 
                //true if blue collides with red
            ||
            
                ((this.gameObject.tag == ("Red")||this.gameObject.tag == ("RedBullet")) && (collision.gameObject.tag == ("Blue")||collision.gameObject.tag == ("BlueBullet")))
            )   //true if red collides with blue
        {
            Destroy(collision.gameObject); //destroy both parties of collision
            Destroy(this.gameObject);
        }
    }
}
