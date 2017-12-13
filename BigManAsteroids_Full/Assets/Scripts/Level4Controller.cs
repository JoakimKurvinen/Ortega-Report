using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level4Controller : MonoBehaviour {
    
    public GameObject SwarmPar;
    public GameObject SmallShip;
    public GameObject BigShip;
    public GameObject Spawn1; //following are possible spawn locations, empty game objects with transforms
    public GameObject Spawn2;
    public GameObject Spawn3;
    public GameObject Spawn4;

    // Use this for initialization
    void Start ()
    {
            StartCoroutine(Waves());//starts the wave coroutine
    }

    // Update is called once per frame
    void Update ()
    {

    }
   
    IEnumerator Waves()
    {

        for (int wavenum = 0; wavenum < 5; wavenum++)//total of 4 waves + victory condition
            //run a for loop for each wave + victory condition
        {
            if (wavenum == 0)//wave 1
            {
                for (int u = 0; u < 5; u++)//spawn 5 swarms
                {
                    Instantiate(SwarmPar, new Vector2(Spawn1.transform.position.x + Random.Range(-30, 30), Spawn1.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                }
                yield return new WaitForSeconds(6);//waits 6 seconds before next wave
            }
            if (wavenum == 1)//wave 2
            {
                for (int j = 0; j < 6; j++)//spawn 6 swarms, 6x3 smallships
                {
                    Instantiate(SwarmPar, new Vector2(Spawn2.transform.position.x + Random.Range(-30, 30), Spawn2.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                    Instantiate(SmallShip, new Vector2(Spawn2.transform.position.x + Random.Range(-30, 30), Spawn2.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                    Instantiate(SmallShip, new Vector2(Spawn3.transform.position.x + Random.Range(-30, 30), Spawn3.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                    Instantiate(SmallShip, new Vector2(Spawn4.transform.position.x + Random.Range(-30, 30), Spawn4.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                    //spawn locations are set but each instance is spawned with random range of coordinates
                }
                yield return new WaitForSeconds(10);//waits 10 seconds before next wave
            }
            if (wavenum == 2)//wave 3
            {
                for (int k = 0; k < 6; k++)//spawn 6x4 bigships
                {
                    Instantiate(BigShip, new Vector2(Spawn1.transform.position.x + Random.Range(-30, 30), Spawn1.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                    Instantiate(BigShip, new Vector2(Spawn2.transform.position.x + Random.Range(-30, 30), Spawn2.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                    Instantiate(BigShip, new Vector2(Spawn3.transform.position.x + Random.Range(-30, 30), Spawn3.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                    Instantiate(BigShip, new Vector2(Spawn4.transform.position.x + Random.Range(-30, 30), Spawn4.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                }
                yield return new WaitForSeconds(12);//waits 12 seconds
            }
            if (wavenum == 3)//wave 4
            {
                
                for (int h = 0; h < 12; h++)//spawns 24x swarms and 24x bigships
                {
                    Instantiate(SwarmPar, new Vector2(Spawn1.transform.position.x + Random.Range(-30, 30), Spawn1.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                    Instantiate(SwarmPar, new Vector2(Spawn2.transform.position.x + Random.Range(-30, 30), Spawn2.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                    Instantiate(BigShip, new Vector2(Spawn3.transform.position.x + Random.Range(-30, 30), Spawn3.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                    Instantiate(BigShip, new Vector2(Spawn4.transform.position.x + Random.Range(-30, 30), Spawn4.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                }
                yield return new WaitForSeconds(35);//waits 35 seconds
            }
            if (wavenum == 4)//victory condition, after elapsed time, if player has survived, victory screen
            {
                SceneManager.LoadScene("Level5", LoadSceneMode.Single);//scene 5 is victory screen
            }
            
        }
    }
    
}