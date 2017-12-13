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

            ||
            
                ((this.gameObject.tag == ("Red")||this.gameObject.tag == ("RedBullet")) && (collision.gameObject.tag == ("Blue")||collision.gameObject.tag == ("BlueBullet")))
            )
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
