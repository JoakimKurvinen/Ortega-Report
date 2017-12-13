using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectiveText : MonoBehaviour {

public GUIStyle myGUIStyle;
	void OnGUI() //method to show wanted text
     {
		
		GUIStyle myStyle = new GUIStyle();
		myStyle.wordWrap = true;
        myStyle.alignment = TextAnchor.MiddleCenter;

		GUI.contentColor = Color.white;
		GUI.color = Color.white;
	

        
		GUI.Box(new Rect ((1920/2)- 600, 130, 1200, 60),"<color=white><size=36>You have arrived in the Ortega star system, but your radar has picked up hostile contacts. Prepare for combat!</size></color>", myStyle);
		StartCoroutine(Bye());
      }
	IEnumerator Bye()
    { //method to hide text and the Panel behind it
        yield return new WaitForSeconds(5);
        GameObject.Find("GameController").GetComponent<ObjectiveText>().enabled = false;
        GameObject.Find("Panel").GetComponent<Image>().enabled = false;
	
	}
	}

