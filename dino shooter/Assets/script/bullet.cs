using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class bullet : MonoBehaviour
{
    public static int points;

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
            points += 3;
            Destroy(collision.gameObject);
            Debug.Log("points: " +  points);
        }
        else if (collision.gameObject.CompareTag("pachy"))
        {
            points += 2;
            Destroy(collision.gameObject);
            Debug.Log("points: " + points);
        }
        else if (collision.gameObject.CompareTag("stego"))
        {
            points += 1;
            Destroy(collision.gameObject);
            Debug.Log("points: " + points);
        }
    }
}
