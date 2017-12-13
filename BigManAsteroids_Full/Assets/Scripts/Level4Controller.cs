using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level4Controller : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.wordWrap = true;


        GUI.contentColor = Color.white;
        GUI.color = Color.white;



        GUI.Box(new Rect(250, 50, 500, 60), "<color=white><size=20>Defend the Colony Ship while they power up to escape the solar system!</size></color>", myStyle);
        StartCoroutine(Bye());
    }
    IEnumerator Bye()
    {
        yield return new WaitForSeconds(5);
        GUI.enabled = false;
    }
}
