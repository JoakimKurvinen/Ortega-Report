using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectiveTextFour : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
public GUIStyle myGUIStyle;
	void OnGUI()
     {
		
		GUIStyle myStyle = new GUIStyle();
		myStyle.wordWrap = true;


		GUI.contentColor = Color.white;
		GUI.color = Color.white;



        GUI.Box(new Rect((1920 / 2) - 250, 130, 500, 60), "<color=white><size=36>Massive radar contact approaching, it's the swarm! Fight for your life!</size></color>", myStyle);
		StartCoroutine(Bye());
      }
	IEnumerator Bye(){
		yield return new WaitForSeconds(2);
        GameObject.Find("GameController").GetComponent<ObjectiveTextFour>().enabled = false;
        GameObject.Find("Panel").GetComponent<Image>().enabled = false;
	
	}
	}
//Contacts approaching! Your arrival to the communications array generated unwanted attention, return at once after fighting off the bogeys. 
