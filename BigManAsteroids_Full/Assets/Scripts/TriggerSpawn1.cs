using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerSpawn1 : MonoBehaviour {

    public GameObject Spawned; //thing that is spawned
    public GameObject TargetLocation; //refernce location
    
    void OnTriggerExit2D(Collider2D Ship) //triggers on exit
    {
        if (Ship.gameObject.name == "PlayerShip") //if name is correct
        {
            //Debug.Log("Object entered trigger zone");
            //spawns objects based on the reference location -+ some coordinates
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 75 , TargetLocation.transform.position.y + 25), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 80, TargetLocation.transform.position.y - 45), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 90, TargetLocation.transform.position.y + 45), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 80, TargetLocation.transform.position.y - 30), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 95, TargetLocation.transform.position.y + 30), TargetLocation.transform.rotation);

            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 150, TargetLocation.transform.position.y + 50), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 160, TargetLocation.transform.position.y + 20), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 165, TargetLocation.transform.position.y + 10), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 155, TargetLocation.transform.position.y + 30), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 160, TargetLocation.transform.position.y + 45), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 145, TargetLocation.transform.position.y + 25), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 150, TargetLocation.transform.position.y + 30), TargetLocation.transform.rotation);

            GameObject.Find("Trigger1").GetComponent<BoxCollider2D>().enabled = false; //disables collider for trigger1
            GameObject.Find("TriggerEnd").GetComponent<BoxCollider2D>().enabled = true; //enables the collider for triggerend
        }
    }
}
