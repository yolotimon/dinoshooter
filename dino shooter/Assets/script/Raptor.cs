using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class Raptor : MonoBehaviour
{
    private GameObject player;
    public static float speed = 5;
    private Rigidbody rb;
    audioManager manager;

    //private static bool hasRun = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        transform.position += transform.forward * speed * Time.deltaTime;

        //if (!rb.IsSleeping() && hasRun == false)
        //{
        //    manager.raptorStomps(manager.dinoStomp);
        //    StartCoroutine("hasItRun");
        //    hasRun = true;
        //}
    }
    //public IEnumerator hasItRun()
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(20.532f);
    //        manager.hasRun = false;
    //        StopCoroutine("hasItRun");
    //    }
    //}

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        manager = GameObject.FindGameObjectWithTag("audioManager").GetComponent<audioManager>();
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("bullet"))
    //    {
            
    //    }
    //}
}
