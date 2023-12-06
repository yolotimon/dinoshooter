using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StopWatch : MonoBehaviour
{
    bool stopwatchActive = false;
    public  static float currentTime;
    public TMP_Text currentTimeText;

    public static float[] timeSeconds = new float[4];
    public static float[] timeMinutes = new float[4];

    public TMP_Text[] minutes = new TextMeshPro[4];
    public TMP_Text[] seconds = new TextMeshPro[4];

    public static int currentRound = 0;

    TimeSpan time = TimeSpan.FromSeconds(currentTime);

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopwatchActive == true) {
            currentTime = currentTime + Time.deltaTime;
        }
        currentTimeText.text = "time: " + time.Minutes.ToString() + ":" + time.Seconds.ToString();
    }

    public void StartStopwatch()
    {
        stopwatchActive = true;
    }

    public void StopStopwatch()
    {
        stopwatchActive = false;
    }

    public void SaveScore()
    {
        if (currentRound < timeSeconds.Length)
        {
            timeMinutes[currentRound] = time.Minutes;
            timeSeconds[currentRound] = time.Seconds;
        }
        currentRound++;
    }
}