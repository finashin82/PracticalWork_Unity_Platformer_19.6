using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakingCoin : MonoBehaviour
{
    [Tooltip("���� ��� ������ ���������� ����� � ������")]
    [SerializeField] private Text _levelMoney;

    [Tooltip("���� ��� ����� ����� ������")]
    [SerializeField] private AudioSource _takingCoin;

    private int levelMoney;
    private int allMoney;

    private void Awake()
    {
        levelMoney = 0;        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            collision.gameObject.SetActive(false);

            _takingCoin.Play();

            PlayerPrefs.SetInt("allMoney", allMoney + 1);

            levelMoney++;
            _levelMoney.text = Convert.ToString(levelMoney);

            
        }

        //Destroy(gameObject);
        
    }
}
