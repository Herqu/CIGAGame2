using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TrainStation : MonoBehaviour
{



    public GameObject m_StoreUI;
    public Animator m_animAtor;
    public AudioSource m_audioSource;
    public Text m_Text;

    private void Awake()
    {
        m_StoreUI = transform.GetChild(0).gameObject;
        m_Text.text = "列车已到达" +TrainStationName+ "";
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
        m_IsTrainstationOn = false;
        m_animAtor.SetTrigger("Play");
        m_ShowWinPanel.DOPlayForward();
        m_audioSource.Play();
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
