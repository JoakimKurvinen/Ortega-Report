using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// check triggerEnd1 for comments. everything is pretty much the same
/// </summary>
public class TriggerEnd2 : MonoBehaviour
{
    public string target;


    void OnTriggerExit2D(Collider2D Ship) //triggers on enter
    {
        Debug.Log(FindTarget("Red"));
        if (FindTarget(target).Length == 2) //if name is correct
        {
            StartCoroutine(NextLevel());

        }

    }
    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Level3", LoadSceneMode.Single);

    }
    GameObject[] FindTarget(string targetTag)
    {
        GameObject[] potTargets;
        
        potTargets = GameObject.FindGameObjectsWithTag(targetTag);

        Debug.Log(potTargets.Length);
        return potTargets;
    }
}
