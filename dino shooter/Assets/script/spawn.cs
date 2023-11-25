using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UI;

public class spawn : MonoBehaviour
{
    public GameObject[] spawns;
    public GameObject raptor;
    public static int round = 0;
    private int RaptorAmount;
    private int SpawnTime = 5;
    private int MaxRaptor = 10;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        round++;
        canvas.SetActive(false);
        StartCoroutine("SpawnRaptor");
    }

    // Update is called once per frame
    void Update()
    {
        if (round == 2)
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
                Instantiate(raptor);
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
