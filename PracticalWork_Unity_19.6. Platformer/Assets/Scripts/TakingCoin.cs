using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakingCoin : MonoBehaviour
{
    [Tooltip("���� ��� ���������� ����� � ������")]
    [SerializeField] private Text _levelMoney;
    
    [Tooltip("���� ��� ���������� ����� �� ������ ������")]
    [SerializeField] private Text _levelWinMoney;

    [Tooltip("���� ��� ����� ����� ������")]
    [SerializeField] private AudioSource _takingCoin;

    private int levelCoin, allCoin;    

    private void Awake()
    {        
        levelCoin = 0;
        PlayerPrefs.SetInt("levelCoin", 0);                
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            
            _takingCoin.Play();
            levelCoin = PlayerPrefs.GetInt("levelCoin");

            levelCoin += 1;
            
            PlayerPrefs.SetInt("levelCoin", levelCoin);
            PlayerPrefs.Save();

            _levelMoney.text = Convert.ToString(levelCoin);                       
        }
    }
}
