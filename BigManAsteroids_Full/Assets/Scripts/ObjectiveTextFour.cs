using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectiveTextFour : MonoBehaviour {

public GUIStyle myGUIStyle;
	void OnGUI() //method to draw the wanted text
     {
		
		GUIStyle myStyle = new GUIStyle();
		myStyle.wordWrap = true;


		GUI.contentColor = Color.white;
		GUI.color = Color.white;



        GUI.Box(new Rect((1920 / 2) - 600, 130, 1200, 60), "<color=white><size=36>Massive radar contact approaching, it's the swarm! Fight for your life! Stay near the tanker to survive!</size></color>", myStyle);
		StartCoroutine(Bye());
      }
	IEnumerator Bye() //method to hide text and the Panel behind it
        {
		    yield return new WaitForSeconds(5);
            GameObject.Find("GameController").GetComponent<ObjectiveTextFour>().enabled = false;
            GameObject.Find("Panel").GetComponent<Image>().enabled = false;
	    }
}

