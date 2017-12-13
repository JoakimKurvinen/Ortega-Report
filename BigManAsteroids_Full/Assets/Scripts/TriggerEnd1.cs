using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnd1 : MonoBehaviour
{
    public string target;


    void OnTriggerExit2D(Collider2D Ship) //triggers on enter
    {
        Debug.Log(FindTarget("Red"));
        if (FindTarget(target).Length == 1) //if name is correct
        {
            StartCoroutine(NextLevel());
            
        }

    }
    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Level2", LoadSceneMode.Single);

    }
    GameObject[] FindTarget(string targetTag)
    {
        GameObject[] potTargets;
        
        potTargets = GameObject.FindGameObjectsWithTag(targetTag);
        Debug.Log(potTargets.Length);
        return potTargets;
    }
}
