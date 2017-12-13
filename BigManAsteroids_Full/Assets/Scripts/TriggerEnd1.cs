using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnd1 : MonoBehaviour
{

    void OnTriggerExit2D(Collider2D Ship) //triggers on enter
    {
        if (Ship.gameObject.tag == "Red") //if name is correct
        {
            SceneManager.LoadScene("Level3", LoadSceneMode.Single);
        }

    }
}
