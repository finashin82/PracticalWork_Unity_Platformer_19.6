using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EndLevel : MonoBehaviour
{
    [Tooltip("Панель победы в уровне")]
    [SerializeField] private GameObject _winLevelPanel;

    [Tooltip("Количество монет за все уровни")]
    [SerializeField] private Text _allCoin;
    
    [Tooltip("Количество монет в уровне")]
    [SerializeField] private Text _levelCoin;

    private int levelCoin, allCoin;    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            
            _winLevelPanel.SetActive(true);

            allCoin = PlayerPrefs.GetInt("allCoin");
            levelCoin = PlayerPrefs.GetInt("levelCoin");

            allCoin += levelCoin;

            _levelCoin.text = Convert.ToString(levelCoin);
            _allCoin.text = Convert.ToString(allCoin);
        }
    }

    /// <summary>
    /// Запись всех монет
    /// </summary>
    public void RecordAllCoin()
    {
        allCoin = PlayerPrefs.GetInt("allCoin");
        levelCoin = PlayerPrefs.GetInt("levelCoin");

        allCoin += levelCoin;

        PlayerPrefs.SetInt("allCoin", allCoin);
        PlayerPrefs.Save();
    }

    /// <summary>
    /// Сброс всех монет
    /// </summary>
    public void ResetAllCoin()
    {
        PlayerPrefs.SetInt("allCoin", 0);
        PlayerPrefs.Save();
    }

    ///// <summary>
    ///// Сброс монет набранных в уровне
    ///// </summary>
    //public void ResetLevelCoin()
    //{
    //    PlayerPrefs.SetInt("levelCoin", 0);
    //    PlayerPrefs.Save();
    //}
}
