using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectiveTextThree : MonoBehaviour {

public GUIStyle myGUIStyle;
	void OnGUI() //method to show wanted text
     {
		GUIStyle myStyle = new GUIStyle();
		myStyle.wordWrap = true;


		GUI.contentColor = Color.white;
		GUI.color = Color.white;

        GUI.Box(new Rect((1920 / 2) - 600, 130, 1200, 60), "<color=white><size=36>The logs you discovered tell us the star system is infested by a hostile lifeform that takes over everything it sees in massive swarms. We must escape Ortega, but we have no fuel. Protect the tanker as it goes to refill from a nearby hydrogen fuel depot. All our lives depend on it.</size></color>", myStyle);
		StartCoroutine(Bye());
      }

	IEnumerator Bye()
    { //method to hide text and the Panel behind it
        yield return new WaitForSeconds(13);
        GameObject.Find("GameController").GetComponent<ObjectiveTextThree>().enabled = false;
        GameObject.Find("Panel").GetComponent<Image>().enabled = false;
	}
	}

