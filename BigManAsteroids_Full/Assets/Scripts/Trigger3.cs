using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger3 : MonoBehaviour
{
    private GameObject MS;
    public GameObject Spawn;
    private GameObject Rekt;

    private void Start()
    {
        MS = GameObject.Find("miningstation");
        Rekt = GameObject.Find("tanker");
    }
    void OnTriggerEnter2D(Collider2D Tank) //triggers on enter
    {
        if (Tank.gameObject.name == "tanker") //if name is correct
        {
            Instantiate(Spawn, new Vector2(MS.transform.position.x, MS.transform.position.y), MS.transform.rotation);
            Destroy(Rekt);
            Destroy(this.gameObject);
            
        }
    }
}
