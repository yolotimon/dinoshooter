using UnityEngine;
using UnityEngine.SceneManagement;

public class startScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void start()
    {
        StopWatch.timeMinutes[0] = 0;
        StopWatch.timeMinutes[1] = 0;
        StopWatch.timeMinutes[2] = 0;
        StopWatch.timeMinutes[3] = 0;
        StopWatch.timeSeconds[0] = 0;
        StopWatch.timeSeconds[0] = 0;
        StopWatch.timeSeconds[1] = 0;
        StopWatch.timeSeconds[2] = 0;
        StopWatch.timeSeconds[3] = 0;
        StopWatch.timeSeconds[4] = 0;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("round1");
    }

}
