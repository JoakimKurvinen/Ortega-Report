using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectiveTextTwo : MonoBehaviour {

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



        GUI.Box(new Rect((1920 / 2) - 250, 130, 500, 60), "<color=white><size=36>You must find out why these strange hostiles attacked us. Follow the asteroid trail to a communications outpost in order to unearth the history of the first wave of colonists, and these hostiles.</size></color>", myStyle);
		StartCoroutine(Bye());
      }
	IEnumerator Bye(){
		yield return new WaitForSeconds(10);
        GameObject.Find("GameController").GetComponent<ObjectiveTextTwo>().enabled = false;
		GameObject.Find("Panel").GetComponent<Image>().enabled = false;
        


    }
	}

