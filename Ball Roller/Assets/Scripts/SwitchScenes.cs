using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Main Level");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
    public void Back()
    {
        SceneManager.LoadScene("Start");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Start");
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
