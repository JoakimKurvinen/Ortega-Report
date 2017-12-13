using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectiveText : MonoBehaviour {

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
        myStyle.alignment = TextAnchor.MiddleCenter;

		GUI.contentColor = Color.white;
		GUI.color = Color.white;
	

        
		GUI.Box(new Rect ((1920/2)-250, 130, 500, 60),"<color=white><size=36>You have arrived in the Ortega star system, but your radar has picked up hostile contacts. Prepare for combat!</size></color>", myStyle);
		StartCoroutine(Bye());
      }
	IEnumerator Bye(){
		yield return new WaitForSeconds(5);
        GameObject.Find("GameController").GetComponent<ObjectiveText>().enabled = false;
        GameObject.Find("Panel").GetComponent<Image>().enabled = false;
	
	}
	}

