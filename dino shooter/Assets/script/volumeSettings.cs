using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class volumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider SFXSlider;

    public void setVolume()
    {
        float volume = SFXSlider.value;
        audioMixer.SetFloat("sfx", Mathf.Log10(volume)*20);
    }

    //private void Update()
    //{
    //    if ()
    //    {

    //    }
    //}
}
