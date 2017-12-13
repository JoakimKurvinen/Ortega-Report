using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level4Controller : MonoBehaviour {
    public GameObject PlayerShip;
    public GameObject SwarmPar;
    public GameObject SmallShip;
    public GameObject BigShip;
    public GameObject Spawn1;
    public GameObject Spawn2;
    public GameObject Spawn3;
    public GameObject Spawn4;

    private bool running = false;
    private GameObject[] gmobj1;
    private GameObject[] gmobj2;

    private bool wave1over = false;
    private bool wave2over = false;
    private bool wave3over = false;
    private bool wave4over = false;

    // Use this for initialization
    void Start ()
    {
            StartCoroutine(Waves());
    }

    /*IEnumerator SpawnWave1()
    {
        yield return new WaitForSeconds(2);
        while (true)
        {
            for (int i = 0; i < 5; i++)
            {
            Instantiate(SwarmPar, new Vector2(Spawn1.transform.position.x + Random.Range(-30, 30), Spawn1.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);

            yield return new WaitForSeconds(5);
            }
            yield return new WaitForSeconds(5);
            }
        }*/
    // Update is called once per frame
    void Update ()
    {

    }
   
    IEnumerator Waves()
    {

        for (int wavenum = 0; wavenum < 5; wavenum++)
        {
            if (wavenum == 0)
            {
                for (int u = 0; u < 5; u++)
                {
                    Instantiate(SwarmPar, new Vector2(Spawn1.transform.position.x + Random.Range(-30, 30), Spawn1.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                }
                yield return new WaitForSeconds(6);
            }
            if (wavenum == 1)
            {
                for (int j = 0; j < 6; j++)
                {
                    Instantiate(SwarmPar, new Vector2(Spawn2.transform.position.x + Random.Range(-30, 30), Spawn2.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                    Instantiate(SmallShip, new Vector2(Spawn2.transform.position.x + Random.Range(-30, 30), Spawn2.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                    Instantiate(SmallShip, new Vector2(Spawn3.transform.position.x + Random.Range(-30, 30), Spawn3.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                    Instantiate(SmallShip, new Vector2(Spawn4.transform.position.x + Random.Range(-30, 30), Spawn4.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);

                }
                yield return new WaitForSeconds(10);
            }
            if (wavenum == 2)
            {
                for (int k = 0; k < 6; k++)
                {
                    Instantiate(BigShip, new Vector2(Spawn1.transform.position.x + Random.Range(-30, 30), Spawn1.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                    Instantiate(BigShip, new Vector2(Spawn2.transform.position.x + Random.Range(-30, 30), Spawn2.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                    Instantiate(BigShip, new Vector2(Spawn3.transform.position.x + Random.Range(-30, 30), Spawn3.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                    Instantiate(BigShip, new Vector2(Spawn4.transform.position.x + Random.Range(-30, 30), Spawn4.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                }
                yield return new WaitForSeconds(12);
            }
            if (wavenum == 3)
            {
                
                for (int h = 0; h < 12; h++)
                {
                    Instantiate(SwarmPar, new Vector2(Spawn1.transform.position.x + Random.Range(-30, 30), Spawn1.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                    Instantiate(SwarmPar, new Vector2(Spawn2.transform.position.x + Random.Range(-30, 30), Spawn2.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                    Instantiate(BigShip, new Vector2(Spawn3.transform.position.x + Random.Range(-30, 30), Spawn3.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                    Instantiate(BigShip, new Vector2(Spawn4.transform.position.x + Random.Range(-30, 30), Spawn4.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                }
                yield return new WaitForSeconds(35);
            }
            if (wavenum == 4)
            {
                SceneManager.LoadScene("Level5", LoadSceneMode.Single);
            }
            yield return new WaitForSeconds(10);
        }
    }
    /*IEnumerator Wave2()
    {
        running = true;
        Debug.Log("starting 2222");
        for (int i = 0; i <= 6; i++)
        {
            Instantiate(SwarmPar, new Vector2(Spawn2.transform.position.x + Random.Range(-30, 30), Spawn2.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
            Instantiate(SmallShip, new Vector2(Spawn2.transform.position.x + Random.Range(-30, 30), Spawn2.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
        }
        yield return new WaitForSeconds(10);
        wave2over = true;
        running = false;
        
    }*/
}













/*

        Debug.Log(wave1over);
        

        gmobj1 = GameObject.FindGameObjectsWithTag("Swarm");
        gmobj2 = GameObject.FindGameObjectsWithTag("Red");

        Debug.Log(gmobj1.Length);
        Debug.Log(gmobj2.Length);

        if (gmobj1.Length <= 1)
        {
            wave1over = true;
        }
        
        if (wave1over == true)
        {
            for (int i = 0; i <= 6; i++)
            {
                Instantiate(SwarmPar, new Vector2(Spawn2.transform.position.x + Random.Range(-30, 30), Spawn2.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
                Instantiate(SmallShip, new Vector2(Spawn2.transform.position.x + Random.Range(-30, 30), Spawn2.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
            }
            
        }
        if (wave1over == true && gmobj2.Length == 0)
        {
            wave2over = true;
        }
        if (wave2over == true)
        {
            Instantiate(SwarmPar, new Vector2(Spawn2.transform.position.x + Random.Range(-30, 30), Spawn2.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);
            Instantiate(SmallShip, new Vector2(Spawn2.transform.position.x + Random.Range(-30, 30), Spawn2.transform.position.y + Random.Range(-30, 30)), Spawn1.transform.rotation);

        }*/
