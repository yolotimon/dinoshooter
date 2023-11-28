using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raptor : MonoBehaviour
{
    private GameObject player;
    public float speed;

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
}
