using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectiveTextThree : MonoBehaviour {

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
	

        
		GUI.Box(new Rect (230, 50, 500, 60),"<color=white><size=20>The logs you discovered tell us the star system is infested by a hostile lifeform that takes over everything it sees in massive swarms. We must escape Ortega, but we have no fuel. Protect the tanker as it goes to refill from a nearby hydrogen fuel depot. All our lives depend on it.</size></color>", myStyle);
		StartCoroutine(Bye());
      }
	IEnumerator Bye(){
		yield return new WaitForSeconds(13);
		gameObject.SetActive(false);
		GameObject.Find("Panel").GetComponent<Image>().enabled = false;
	
	}
	}

