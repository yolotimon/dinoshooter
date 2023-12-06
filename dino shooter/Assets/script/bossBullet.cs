using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEditor;
using UnityEngine;

public class bossBullet : MonoBehaviour
{
    public static GameObject boss;

    private void Update()
    {
        boss = GameObject.FindGameObjectWithTag("boss");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("boss"))
        {
            Boss.bossHPleft--;
            Debug.Log("HP: " + Boss.bossHPleft);
            Boss.one = 0;
            boss.GetComponent<Boss>().starthp();
        }
    }
}
    //private int bossHPleft = 5;
    //private GameObject boss;
    //public int one = 0;

    
    //// Start is called before the first frame update
    //void Start()
    //{
    //    boss = GameObject.FindGameObjectWithTag("boss");
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (bossHPleft == 0)
    //    {
    //        Destroy(boss);
    //    }

    //    if (one == 1)
    //    {
    //        StopCoroutine("BossImmunity");
    //    }
    //}

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

    //public IEnumerator BossImmunity()
    //{
    //    while (true)
    //    {
    //        Debug.Log("deactivated collider");
    //        boss.GetComponent<MeshCollider>().enabled = false;
    //        yield return new WaitForSeconds(5);
    //        Debug.Log("activated collider");
    //        boss.GetComponent<MeshCollider>().enabled = true;
    //        one++;
    //        yield return new WaitForSeconds(0.1f); 
    //    }
    //}

    //private void Awake()
    //{

    //}