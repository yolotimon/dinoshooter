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

    private void Reset()
    {
        spawn.round = 0;
        spawn.RaptorAmount = 0;
        SceneManager.LoadScene("SampleScene");
    }
}
