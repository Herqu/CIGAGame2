using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TrainStation : MonoBehaviour
{



    public GameObject m_StoreUI;

    private void Awake()
    {
        m_StoreUI = transform.GetChild(0).gameObject;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (m_IsTrainstationOn)
        {
            if (collision.tag == "Train")
            {
                GameLevelWin();
            }
        }

    }




    public void GameLevelWin()
    {
        Time.timeScale = 0;
        m_IsTrainstationOn = false;
        GetComponent<SpriteRenderer>().color = Color.gray;
        m_ShowWinPanel.DOPlayForward();
    }



    public bool m_IsTrainstationOn = true;
    public string TrainStationName;
    public DOTweenAnimation m_ShowWinPanel;




    public void UICloseStoreUI()
    {
        Time.timeScale = 1f;
        m_ShowWinPanel.DOPlayBackwards();

    }




}
