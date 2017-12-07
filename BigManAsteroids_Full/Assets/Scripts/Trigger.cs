using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour {

    private Text Text1;

    void Start()
    {
        Text1 = GameObject.Find("Text1").GetComponent<Text>(); //gets the text1 object
    }

    private void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            Text1.color = new Color(255, 255, 255, 0); //hides text1
        }
    }


    void OnTriggerEnter2D (Collider2D Player) //triggers on enter
    {
        if (Player.gameObject.name == "PlayerShip" ) //if name is correct
        {
            Debug.Log("Player entered trigger zone");
            Text1.color = new Color(255, 255, 255, 255); //shows text1
            GameObject.Find("Trigger1").GetComponent<Collider2D>().enabled = false;
        }
    }
}
