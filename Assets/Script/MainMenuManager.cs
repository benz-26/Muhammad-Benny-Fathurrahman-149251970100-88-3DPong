using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
