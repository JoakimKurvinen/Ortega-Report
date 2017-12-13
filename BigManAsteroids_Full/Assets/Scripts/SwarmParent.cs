using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmParent : MonoBehaviour
{



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.childCount <= 2)//if there is 2 or less minions surrounding the parent, parent and all remaining
            //minions are destroyed
        {
            Destroy(this.gameObject);
        }
    }
}

