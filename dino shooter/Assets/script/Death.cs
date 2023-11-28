using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        spawn.raptorsKilled = 0;
        spawnRound2.raptorsKilled = 0;
        spawnRound3.raptorsKilled = 0;
        spawn.RaptorAmount = 0;
        spawnRound3.RaptorAmount = 0;
        spawnRound2.RaptorAmount = 0;
        SceneManager.LoadScene("start");
    }
}
