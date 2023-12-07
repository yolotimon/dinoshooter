using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreDisplayer : MonoBehaviour
{

    public static float[] timeSeconds = new float[4];
    public static float[] timeMinutes = new float[4];

    public TMP_Text[] minutes = new TextMeshPro[4];
    public TMP_Text[] seconds = new TextMeshPro[4];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        minutes[0].text = timeMinutes[0] + ":";
        minutes[1].text = timeMinutes[1] + ":";
        minutes[2].text = timeMinutes[2] + ":";
        minutes[3].text = timeMinutes[3] + ":";
        seconds[0].text = timeSeconds[0] + "";
        seconds[1].text = timeSeconds[1] + "";
        seconds[2].text = timeSeconds[2] + "";
        seconds[3].text = timeSeconds[3] + "";
    }


}
