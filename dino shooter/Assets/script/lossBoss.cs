using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lossBoss : MonoBehaviour
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
        if (gameObject.CompareTag("boss"))
        {
            Time.timeScale = 0f;
            canvas.SetActive(true);
        }
    }
}