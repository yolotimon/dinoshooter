using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Boss : MonoBehaviour
{
    public static int bossHPleft = 5;
    private GameObject boss;
    public static int one = 0;
    private GameObject player;
    public static float speed = 5;
    private Rigidbody rb;
    audioManager manager;
    public GameObject canvas;
    private GameObject xrOrigin;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        manager = GameObject.FindGameObjectWithTag("audioManager").GetComponent<audioManager>();
        xrOrigin = GameObject.FindGameObjectWithTag("xrOrigin");
    }

    // Start is called before the first frame update
    void Start()
    {
        boss = GameObject.FindGameObjectWithTag("boss");
        rb = boss.GetComponent<Rigidbody>();
        Time.timeScale = 1f;
        xrOrigin.GetComponent<StopWatch>().StartStopwatch();
    }

    // Update is called once per frame
    void Update()
    {
        if (bossHPleft == 0)
        {
            xrOrigin.GetComponent<StopWatch>().SaveScore();
            xrOrigin.GetComponent<StopWatch>().StopStopwatch();
            canvas.SetActive(true);
            Destroy(boss);
        }

        if (one == 1)
        {
            StopCoroutine("BossImmunity");
        }

        transform.LookAt(player.transform);
        transform.position += transform.forward * speed * Time.deltaTime;

        if (!rb.IsSleeping() && manager.hasRun == false)
        {
            manager.PlayStomps(manager.dinoStomp);
            StartCoroutine("hasItRun");
            manager.hasRun = true;

        }
    }

    public IEnumerator hasItRun()
    {
        while (true)
        {
            yield return new WaitForSeconds(20.532f);
            manager.hasRun = false;
            StopCoroutine("hasItRun");
        }
    }

    public void starthp()
    {
        StartCoroutine("BossImmunity");
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("boss"))
    //    {
    //        bossHPleft--;
    //        Debug.Log("HP: " + bossHPleft);
    //        one = 0;
    //        StartCoroutine("BossImmunity");
    //    }
    //}

    public IEnumerator BossImmunity()
    {
        while (true)
        {
            Debug.Log("deactivated collider");
            boss.GetComponent<MeshCollider>().enabled = false;
            yield return new WaitForSeconds(5);
            Debug.Log("activated collider");
            boss.GetComponent<MeshCollider>().enabled = true;
            one++;
            yield return new WaitForSeconds(0.1f);
        }
    }


}
