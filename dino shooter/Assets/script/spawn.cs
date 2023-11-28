using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UI;

public class spawn : MonoBehaviour
{
    //public Transform[] spawns;
    public Transform[] spawnLocations;
    public GameObject raptor;
    public static int round = 0;
    public static int RaptorAmount;
    private int SpawnTime;
    private int MaxRaptor;
    public GameObject canvas;
    //public Transform RandomSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        
        round++;
        canvas.SetActive(false);
        Time.timeScale = 1;
        StartCoroutine("SpawnRaptor");
    }

    // Update is called once per frame
    void Update()
    {
        if (round == 1)
        {
            SpawnTime = 5;
            MaxRaptor = 10;
        }
        else if (round == 2)
        {
            SpawnTime = 3;
            MaxRaptor = 15;
        }
        else if (round == 3)
        {
            SpawnTime = 1;
            MaxRaptor = 20;
        }

        if (RaptorAmount >= MaxRaptor)
        {
            StopCoroutine("SpawnRaptor");
            //round++;
            RaptorAmount = 0;
            //StartCoroutine("SpawnRaptor");
        }

        //RandomSpawn = spawns[Random.Range(0, 19)];
    }

    //public void SpawnRandom()
    //{
    //    Instantiate(spawns[UnityEngine.Random.Range(0, spawns.Length - 1)]);
    //}

    public void startspawns()
    {
        
    }

    public IEnumerator SpawnRaptor()
    {
        while (true)
        //for (int i = 0; i <= MaxRaptor; i++)
        {
            {
                Instantiate(raptor, spawnLocations[Random.Range(0,19)]);
                Debug.Log("spawned raptor");
                RaptorAmount++;
                Debug.Log("time: " + SpawnTime);
                Debug.Log("round: " + round);
                Debug.Log("max: " + MaxRaptor);
                Debug.Log("Raptors: " + RaptorAmount);
                yield return new WaitForSeconds(SpawnTime);
            }
        }
    }
}
