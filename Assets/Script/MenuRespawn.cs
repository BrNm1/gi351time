using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuRespawn : MonoBehaviour
{
    public PlayerManager manager;
    public GameObject respawnMenu;
    public GameObject player;
    public GameObject startPoint;

    private string currentScene;
    
    public void OnRespawnButton()
    {
        if (manager.lives > 0)
        {
            manager.Respawn();
        }
    }
    
    public void OnMenuButton()
    {
        //manager.ResetGame();
        respawnMenu.SetActive(false);
        
        SceneManager.LoadSceneAsync(2);
    }
}
