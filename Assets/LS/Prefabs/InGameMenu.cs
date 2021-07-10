using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
 
    public void StopGame()
    {
        if (Time.timeScale == 1)
            Time.timeScale = 0f;
        else
            Time.timeScale= 1f;

    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");

    }
}
