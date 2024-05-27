using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakingCoin : MonoBehaviour
{
    [Tooltip("���� ��� ���������� ����� � ������")]
    [SerializeField] private Text _levelMoney;
    
    [Tooltip("���� ��� ����� ����� ������")]
    [SerializeField] private AudioSource _takingCoin;

    private int levelCoin;    

    private void Awake()
    {        
        levelCoin = 0;
        PlayerPrefs.SetInt("levelCoin", 0);
        PlayerPrefs.Save();
    }

    private void Update()
    {
        _levelMoney.text = Convert.ToString(levelCoin);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            collision.gameObject.SetActive(false);
            
            //_takingCoin.Play();

            levelCoin++;

            PlayerPrefs.SetInt("levelCoin", levelCoin);
            PlayerPrefs.Save();                      

            _levelMoney.text = Convert.ToString(levelCoin);
        }
    }
}
