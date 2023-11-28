using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class spawn : MonoBehaviour
{
    //public Transform[] spawns;
    public Transform[] spawnLocations;
    public GameObject raptor;
    public static int RaptorAmount;
    private int SpawnTime = 5;
    public static int MaxRaptor = 10;
    public GameObject canvas;
    //public Transform RandomSpawn;
    public GameObject FirstCanvas;
    public static bool canvasActive;
    public static int raptorsKilled;
    

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        canvasActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        //if (round == 1)
        //{
        //    SpawnTime = 5;
        //    MaxRaptor = 10;
        //}
        //if (round == 2)
        //{
        //    SpawnTime = 3;
        //    MaxRaptor = 15;
        //}
        //else if (round == 3)
        //{
        //    SpawnTime = 1;
        //    MaxRaptor = 20;
        //}

        if (raptorsKilled == MaxRaptor)
        {
            StopCoroutine("SpawnRaptor");
            //round++;
            RaptorAmount = 0;
            //StartCoroutine("SpawnRaptor");
            FirstCanvas.SetActive(true);
            PauzeMenu.MenuActive = true;
            Time.timeScale = 0f;
        }

        //RandomSpawn = spawns[Random.Range(0, 19)];
    }

    //public void SpawnRandom()
    //{
    //    Instantiate(spawns[UnityEngine.Random.Range(0, spawns.Length - 1)]);
    //}

    public void startspawns()
    {
        canvas.SetActive(false);
        Time.timeScale = 1;
        StartCoroutine("SpawnRaptor");
        canvasActive = false;
    }

    public IEnumerator SpawnRaptor()
    {
        while (true)
        //for (int i = 0; i <= MaxRaptor; i++)
        {
            {
                
                {
                    Instantiate(raptor, spawnLocations[Random.Range(0, 15)]);
                    Debug.Log("spawned raptor");
                    RaptorAmount++;
                    Debug.Log("time: " + SpawnTime);
                    Debug.Log("max: " + MaxRaptor);
                    Debug.Log("Raptors: " + RaptorAmount);
                    yield return new WaitForSeconds(SpawnTime);
                }
              
            }
        }
    }

    //void Update()
    //{
    //    if (spawn.RaptorAmount > spawn.MaxRaptor)
    //    {
    //        FirstCanvas.SetActive(true);
    //        PauzeMenu.MenuActive = true;
    //        Time.timeScale = 0f;
    //    }
    //}

    public void NextRound()
    {
        RaptorAmount = 0;
        canvasActive = false;
        Time.timeScale = 1f;
        FirstCanvas.SetActive(false);
        SceneManager.LoadScene("round2");
    }


    public void StartScene()
    {
        RaptorAmount = 0;
        canvasActive = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("start");
        FirstCanvas.SetActive(false);
    }
}
