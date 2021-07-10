using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseUI : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.m_CurrentHeart<= 0)
        {
            
        }
    }



    public GameObject GameOverUI;
    public void GameOver()
    {
        GameOverUI.SetActive(true);
        
    }
}
