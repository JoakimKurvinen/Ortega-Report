using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmParent : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    GameObject FindTarget(string targetTag)
    {
        GameObject[] potTargets;
        List<float> potDistance = new List<float>();
        int IndexMin = 0;

        //PUTTING ALL POTENTIONAL TARGETS INTO LIST OF GAMEOBJECTS
        potTargets = GameObject.FindGameObjectsWithTag(targetTag);

        if (potTargets.Length == 0)
        {
            return null;
        }

        foreach (GameObject n in potTargets)//Checking for distance to each object
        {
            potDistance.Add((n.transform.position - transform.position).magnitude);
        }

        //FINDING SMALLEST DISTANCE VALUE

        for (int m = 0; m < potTargets.Length; m++)
        {
            if (potDistance[m] < potDistance[IndexMin])    //compare Min with every value,
            {
                IndexMin = m;   //if smaller value is found, set Min to smaller value
            }
        }
        return (potTargets[IndexMin]);
    }
}
