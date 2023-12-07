using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnRound3 : MonoBehaviour
{
    //public Transform[] spawns;
    public Transform[] spawnLocations;
    public GameObject[] dinos;

    private int SpawnTime = 3;

    private GameObject xrOrigin;

    public GameObject canvas;
    //public Transform RandomSpawn;
    public GameObject FirstCanvas;

    private int pointrequirement = 40;

    private void Awake()
    {
        xrOrigin = GameObject.FindGameObjectWithTag("xrOrigin");
    }

    // Start is called before the first frame update
    void Start()
    {

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

        if (bullet.points >= pointrequirement)
        {
            StopCoroutine("SpawnRaptor");
            //round++;
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
        StartCoroutine("SpawnRaptor");
    }

    public IEnumerator SpawnRaptor()
    {
        while (true)
        //for (int i = 0; i <= MaxRaptor; i++)
        {
            {
                
                {
                    Instantiate(dinos[Random.Range(0, 3)], spawnLocations[Random.Range(0, 20)]);
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


    public void NextRound2()
    {
        Time.timeScale = 1f;
        xrOrigin.GetComponent<StopWatch>().SaveScore();
        SceneManager.LoadScene("boss");
        FirstCanvas.SetActive(false);
    }

    public void StartScene()
    {
        bullet.points = 0;
        Time.timeScale = 1f;
        FirstCanvas.SetActive(false);
        SceneManager.LoadScene("start");
    }
}
