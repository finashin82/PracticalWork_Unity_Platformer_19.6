using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EndLevel : MonoBehaviour
{
    [Tooltip("������ ������ � ������")]
    [SerializeField] private GameObject _winLevelPanel;

    [Tooltip("���������� ����� � ������")]
    [SerializeField] private Text _levelCoin;

    [Tooltip("���������� ����� �� ��� ������")]
    [SerializeField] private Text _allCoin;

    private int levelCoin, allCoin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            levelCoin = PlayerPrefs.GetInt("levelCoin");
            allCoin = PlayerPrefs.GetInt("allCoin");

            allCoin += levelCoin;

            _levelCoin.text = Convert.ToString(levelCoin);
            _allCoin.text = Convert.ToString(allCoin);

            _winLevelPanel.SetActive(true);
        }
    }

    public void RecordAllCoin()
    {
        PlayerPrefs.SetInt("allCoin", allCoin);
    }

    public void ResetAllCoin()
    {
        PlayerPrefs.SetInt("allCoin", 0);
    }
}
