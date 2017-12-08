using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmMinion : MonoBehaviour {

    public GameObject AttachedShip;
    public float ForceMultiplier;
    public float Power;

    private Rigidbody2D rigidbodyMinion;
    private Vector2 target;
    private Vector2 offset;
    private Vector2 targetVector;

    // Use this for initialization
    void Start () {
        rigidbodyMinion = this.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        target = new Vector2(AttachedShip.transform.position.x, AttachedShip.transform.position.y); //position of target
        targetVector = new Vector2(this.transform.position.x, this.transform.position.y) - target; //vector towards target
        rigidbodyMinion.AddForce(targetVector.normalized * ForceMultiplier * Mathf.Pow(targetVector.magnitude, Power));
        //unit vector to get direction * multiplier var * distance to target to the power of var (this ensures further away
        //minion gets, the larger the force towards center is
        
	}
}
