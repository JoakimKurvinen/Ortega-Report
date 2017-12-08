using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmMinion : MonoBehaviour {

    public GameObject AttachedShip;

    private Rigidbody2D rigidbodyMinion;

    // Use this for initialization
    void Start () {
        rigidbodyMinion = this.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
