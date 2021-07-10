using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class InGameMenu : MonoBehaviour
{

    public DOTweenAnimation m_StopPanelUP;
    public DOTweenAnimation m_StopPanelDown;

    public void StopGame()
    {

        if (Time.timeScale == 1)
        {
            m_StopPanelUP.DOPlay();
            Time.timeScale = 0f;
        }
        else
        {
            m_StopPanelDown.DOPlay();
            Time.timeScale = 1f;

        }


    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");

    }
}
