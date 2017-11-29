using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speedometer : MonoBehaviour {

    public Text SpeedoMeterText;
    public float SpeedNumber;
    public Rigidbody2D shiprigid;
    



	// Use this for initialization
	void Start () {

        GameObject PlayerShip = GameObject.Find("PlayerShip"); //Finds playership
        //PlayerShipController playerShipScript = PlayerShip.GetComponent<PlayerShipController>();
        shiprigid = PlayerShip.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        float tempspeed = shiprigid.velocity.magnitude;
        tempspeed = Mathf.FloorToInt(tempspeed);
        SpeedoMeterText.text = "Speed = " + tempspeed;
	}
}
