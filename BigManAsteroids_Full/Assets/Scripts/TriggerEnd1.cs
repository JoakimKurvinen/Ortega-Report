using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnd1 : MonoBehaviour
{

    void OnTriggerExit2D(Collider2D Ship) //triggers on enter
    {
        if (FindTarget("Red").Length == 0) //if name is correct
        {
            SceneManager.LoadScene("Level3", LoadSceneMode.Single);
        }

    }
    GameObject[] FindTarget(string targetTag)
    {
        GameObject[] potTargets;
        
        potTargets = GameObject.FindGameObjectsWithTag(targetTag);

        return potTargets;
    }
}
