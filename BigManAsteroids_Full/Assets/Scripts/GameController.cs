using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool showcursor;

    private void Start()
    {
        Cursor.visible = showcursor; //hides the cursor so that the crosshair and the crosshair is used instead
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            Scene loadedLevel = SceneManager.GetActiveScene(); 
            SceneManager.LoadScene(loadedLevel.buildIndex); //restarts the current scene if r is pressed
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit(); //quits the game on esc press
        }
            
    }
}

