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
        scoreDisplayer.timeMinutes[0] = 0;
        scoreDisplayer.timeMinutes[1] = 0;
        scoreDisplayer.timeMinutes[2] = 0;
        scoreDisplayer.timeMinutes[3] = 0;
        scoreDisplayer.timeSeconds[0] = 0;
        scoreDisplayer.timeSeconds[1] = 0;
        scoreDisplayer.timeSeconds[2] = 0;
        scoreDisplayer.timeSeconds[3] = 0;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("round1");
    }

}
