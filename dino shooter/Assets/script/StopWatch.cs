using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class StopWatch : MonoBehaviour
{
    bool stopwatchActive = false;
    public  static float currentTime;
    public TMP_Text currentTimeText;

    public static int currentRound = 0;

    public static float minutes;
    public static float seconds;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;

    }

    // Update is called once per frame
    void Update()
    {
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        if (stopwatchActive == true) {
            currentTime = currentTime + Time.deltaTime;
        }
        currentTimeText.text = "time: " + time.Minutes.ToString() + ":" + time.Seconds.ToString();
        minutes = time.Minutes;
        seconds = time.Seconds;
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
        if (currentRound < scoreDisplayer.timeSeconds.Length)
        {
            scoreDisplayer.timeMinutes[currentRound] = minutes;
            scoreDisplayer.timeSeconds[currentRound] = seconds;
        }
        Debug.Log("saved, time: " + scoreDisplayer.timeMinutes[currentRound] + ":" + scoreDisplayer.timeSeconds[currentRound]);
        currentRound++;
    }

}