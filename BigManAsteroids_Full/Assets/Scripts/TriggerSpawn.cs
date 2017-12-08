using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerSpawn : MonoBehaviour {

    public GameObject Spawned;
    
    void OnTriggerEnter2D(Collider2D Ship) //triggers on enter
    {
        if (Ship.gameObject.name == "PlayerShip") //if name is correct
        {
            Debug.Log("Object entered trigger zone");
            Instantiate(Spawned, new Vector2(transform.position.x, transform.position.y + 15), transform.rotation);
            Instantiate(Spawned, new Vector2(transform.position.x - 10, transform.position.y + 15), transform.rotation);
            Instantiate(Spawned, new Vector2(transform.position.x + 10, transform.position.y + 15), transform.rotation);
            Instantiate(Spawned, new Vector2(transform.position.x + 5, transform.position.y + 20), transform.rotation);
            Instantiate(Spawned, new Vector2(transform.position.x - 5, transform.position.y + 20), transform.rotation);
            // spawns indicated object at triggers center position +- values

        }
    }
}
