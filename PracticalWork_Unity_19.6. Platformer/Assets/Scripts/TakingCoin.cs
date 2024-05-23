using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakingCoin : MonoBehaviour
{
    [Tooltip("Поле для текста количества монет в уровне")]
    [SerializeField] private Text _levelMoney;

    [Tooltip("Поле для звука сбора монеты")]
    [SerializeField] private AudioSource _takingCoin;

    private int levelCoin;    

    private void Awake()
    {
        levelCoin = 0;
        PlayerPrefs.SetInt("levelCoin", levelCoin);                
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            collision.gameObject.SetActive(false);

            _takingCoin.Play();

            levelCoin += 1;
            PlayerPrefs.SetInt("levelCoin", levelCoin);

            _levelMoney.text = Convert.ToString(levelCoin);            
        }
    }
}
