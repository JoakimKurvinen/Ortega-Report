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
	 public GUIStyle myGUIStyle;

	void OnGUI()
     {
		
		GUIStyle myStyle = new GUIStyle();
		myStyle.wordWrap = true;


		GUI.contentColor = Color.white;
		GUI.color = Color.white;
	

        
		GUI.Box(new Rect (250, 50, 500, 60),"<color=white><size=20>You have arrived in the star system, but the radar has picked up contacts. Prepare for combat!</size></color>", myStyle);
		StartCoroutine(Bye());
      }
	IEnumerator Bye(){
		yield return new WaitForSeconds(5);
	
	}
}
