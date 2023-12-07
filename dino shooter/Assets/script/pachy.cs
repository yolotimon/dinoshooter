using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class pachy : MonoBehaviour
{
    private GameObject player;
    public static float speed = 4;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        transform.position += transform.forward * speed * Time.deltaTime;


    }



    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("bullet"))
    //    {
            
    //    }
    //}
}
