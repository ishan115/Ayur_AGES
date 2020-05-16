using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void StartupScene()
    {
        SceneManager.LoadScene("Startup");
    }

    public void MainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
