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


		GUI.contentColor = Color.white;
		GUI.color = Color.white;
	

        
		GUI.Box(new Rect (230, 50, 500, 60),"<color=white><size=20>You have arrived in the star system, but the radar has picked up contacts. Prepare for combat!</size></color>", myStyle);
		StartCoroutine(Bye());
      }
	IEnumerator Bye(){
		yield return new WaitForSeconds(5);
		gameObject.SetActive(false);
		GameObject.Find("Panel").GetComponent<Image>().enabled = false;
	
	}
	}

