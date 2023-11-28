using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("raptor"))
        {
            spawn.raptorsKilled++;
            spawnRound2.raptorsKilled++;
            spawnRound3.raptorsKilled++;
            Destroy(collision.gameObject);
        }
    }
}
