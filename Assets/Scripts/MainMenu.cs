using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void UI()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
    public void Tour()
    {
        SceneManager.LoadScene(2,LoadSceneMode.Single);
    }

    public void Exploration()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }

   
}
