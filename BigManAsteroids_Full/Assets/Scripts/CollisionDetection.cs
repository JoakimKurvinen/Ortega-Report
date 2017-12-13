using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour {

    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if  (
                (this.gameObject.tag == ("Blue") && collision.gameObject.tag == ("Red")) 

            ||
            
                (this.gameObject.tag == ("Red") && collision.gameObject.tag == ("Blue"))
            )
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
