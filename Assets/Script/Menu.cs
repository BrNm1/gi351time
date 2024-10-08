using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void Mmenu() 
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void Play()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
