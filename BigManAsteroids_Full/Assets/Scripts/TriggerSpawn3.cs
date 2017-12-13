using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerSpawn3 : MonoBehaviour
{
    public GameObject Spawned; //differnt things that wanted to spawn
    public GameObject Spawned2;
    public GameObject Spawned3;
    public GameObject TargetLocation;

    void Start()
    {
        TargetLocation = GameObject.Find("PlayerShip");
    }
    void OnTriggerExit2D(Collider2D Tank) //triggers on exit
    {
        if (Tank.gameObject.name == "tanker(Clone)") //if name is correct
        {
            //Debug.Log("Object entered trigger zone");
            //spawns enemies at a certain random location from the player
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(40, 70)), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(40, 70)), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(40, 70)), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(40, 70)), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(40, 70)), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(40, 70)), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(40, 70)), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(40, 70)), TargetLocation.transform.rotation);

            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(140, 180)), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(140, 180)), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(140, 180)), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(140, 180)), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(140, 180)), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(140, 180)), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(140, 180)), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(140, 180)), TargetLocation.transform.rotation);

            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(300, 350)), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(300, 350)), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(300, 350)), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(300, 350)), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(300, 350)), TargetLocation.transform.rotation);

            Instantiate(Spawned2, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(450, 460)), TargetLocation.transform.rotation);

            Instantiate(Spawned2, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(550, 560)), TargetLocation.transform.rotation);
            Instantiate(Spawned2, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(550, 560)), TargetLocation.transform.rotation);

            Instantiate(Spawned3, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(650, 660)), TargetLocation.transform.rotation);
            Instantiate(Spawned3, new Vector2(TargetLocation.transform.position.x - Random.Range(-30, 40), TargetLocation.transform.position.y - Random.Range(650, 660)), TargetLocation.transform.rotation);

            GameObject.Find("Trigger2").GetComponent<BoxCollider2D>().enabled = false; //disables collider for trigger2
            GameObject.Find("TriggerEnd").GetComponent<BoxCollider2D>().enabled = true; //enables triggerend collider
        }
    }
}
