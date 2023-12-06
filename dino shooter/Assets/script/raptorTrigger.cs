using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raptorTrigger : MonoBehaviour
{
    public GameObject canvas;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("raptor"))
        {
            Destroy(other);
            canvas.SetActive(true);
            Time.timeScale = 0;
            
        }
        else if (other.CompareTag("stego"))
        {
            Destroy(other);
            canvas.SetActive(true);
            Time.timeScale = 0;
        }
        else if (other.CompareTag("pachy"))
        {
            Destroy(other);
            canvas.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
