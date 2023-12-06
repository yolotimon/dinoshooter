using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauzeMenu : MonoBehaviour
{
    public GameObject menu;
    public static bool MenuActive = false;
    GameObject presser;

    // Start is called before the first frame update
    void Start()
    {

    }

    //public void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.CompareTag("righthand") && MenuActive == false && other.gameObject == presser)
    //    {
    //        menu.SetActive(true);
    //        MenuActive = true;
    //    }
    //}

    public void menuOpen()
    {
        if (MenuActive == false)
        {
            menu.SetActive(true);
            MenuActive = true;
        }
        else if (MenuActive == true)
        {
            menu.SetActive(false);
            MenuActive = false;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ContinueGame()
    {
        menu.SetActive(false);
        MenuActive = false;
    }

    public void StartMenu()
    {
        SceneManager.LoadScene("start");
    }

    //public void quit()
    //{
    //    Application.Quit();
    //    Debug.Log("Quit");
    //}

    //public void mainMenu()
    //{
    //    scoreManager.currentRound = 0;
    //    scoreManager.allScore[0] = 0;
    //    scoreManager.allScore[1] = 0;
    //    scoreManager.allScore[2] = 0;
    //    MenuActive = false;
    //    Time.timeScale = 1f;
    //    SceneManager.LoadScene("begin");
    //}
}