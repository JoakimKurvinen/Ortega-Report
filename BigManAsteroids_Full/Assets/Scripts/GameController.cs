using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject Turret;
    public GameObject Player;


    void TextBox()
    {
        GUI.Label(new Rect(10, 10, 0, 20), "Perkele");
    }

    // Use this for initialization
    void Start () {
        /*SpawnTurrets();
        Instantiate(Player, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
        Debug.Log("playercreated");*/

    }
	
	// Update is called once per frame
	void Update () {
        

	}
    /*void SpawnTurrets()
    {
        for (int i = 0; i < 5; i++) {
            Instantiate(Turret, new Vector3(Random.Range(-30.0f, 30.0f), Random.Range(-30.0f, 30.0f),-1), Quaternion.Euler(0, 0, Random.Range(-0.0f, 359.0f)));
        }
    }*/
}
