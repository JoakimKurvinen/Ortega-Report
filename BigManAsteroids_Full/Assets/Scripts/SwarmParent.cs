﻿using System.Collections;
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
        if (this.transform.childCount <= 2)
        {
            Destroy(this.gameObject);
        }
    }
}

