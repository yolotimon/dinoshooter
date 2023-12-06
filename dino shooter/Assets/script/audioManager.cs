using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    //private GameObject raptors;
    
    [Header("-------------audio source-------------")]
    [SerializeField] AudioSource SFXSource;
    //AudioSource RaptorSource;

    [Header("-------------audio clips--------------")]
    public AudioClip dinoStomp;

    public bool hasRun = false;

    private void Start()
    {
        //raptors = GameObject.FindGameObjectWithTag("raptor");
        //RaptorSource = raptors.GetComponent<AudioSource>();
    }

    public void PlayStomps(AudioClip clip)
    {
        if (hasRun == false) 
        {
            SFXSource.PlayOneShot(clip);
        }
    }

    //public void raptorStomps(AudioClip clip)
    //{
    //    RaptorSource.PlayOneShot(clip);
        
    //}
}
