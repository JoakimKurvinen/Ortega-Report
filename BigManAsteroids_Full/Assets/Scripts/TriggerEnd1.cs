using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnd1 : MonoBehaviour
{
    public string target; //the wanted tag


    void OnTriggerExit2D(Collider2D Ship) //triggers on exit
    {
       // Debug.Log(FindTarget("Red"));
        if (FindTarget(target).Length == 1) //if array lenght is correct
        {
            StartCoroutine(NextLevel()); //start the timer to load the next level
        }

    }
    IEnumerator NextLevel() //method to load next level
    {
        yield return new WaitForSeconds(5); //5s timer
        SceneManager.LoadScene("Level2", LoadSceneMode.Single); //loads level2 
    }

    GameObject[] FindTarget(string targetTag)//returns an array of objects with tag targetTag
    {
        GameObject[] potTargets;
        
        potTargets = GameObject.FindGameObjectsWithTag(targetTag);
        Debug.Log(potTargets.Length);
        return potTargets;
    }
}
