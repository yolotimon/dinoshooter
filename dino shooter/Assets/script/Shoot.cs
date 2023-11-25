using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.XR.Interaction.Toolkit;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnpoint;
    public float firespeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(ShootBullet);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShootBullet (ActivateEventArgs arg)
    {
        GameObject spawnedBullet = Instantiate(bullet);
        spawnedBullet.transform.position = spawnpoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnpoint.forward * firespeed;
        Destroy(spawnedBullet, 5);
    }

}
