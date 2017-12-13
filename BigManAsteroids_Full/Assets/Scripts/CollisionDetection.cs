using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour {

    //private GameObject Enemy;
   // private int RemainingEnemies = 11;
	// Use this for initialization
	void Start () {
        //Enemy = GameObject.Find("small_ships (1)(Clone)");

    }
	
	// Update is called once per frame
/*	void Update () {
        if (RemainingEnemies == 0)
        {
            SceneManager.LoadScene("Level3", LoadSceneMode.Single);
        }
    }

    void NextLevel()
    {
        Debug.Log("Red destroyed"); */
        /*if (Enemy == null)
        {
            SceneManager.LoadScene("Level3", LoadSceneMode.Single);
        }*/
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
       /* if (this.gameObject.name == ("bullet(Clone)") && collision.gameObject.name == ("small_ships (1)(Clone)"))
        {
            RemainingEnemies -= 1;
         */


        if  (
                (this.gameObject.tag == ("Blue") && collision.gameObject.tag == ("Red")) 

            ||
            
                (this.gameObject.tag == ("Red") && collision.gameObject.tag == ("Blue"))
            )
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            NextLevel();
        }
    }
}
