using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakingCoin : MonoBehaviour
{
    [SerializeField] private Text _levelMoney;

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
            PlayerPrefs.SetInt("allMoney", allMoney + 1);

            levelMoney++;
            _levelMoney.text = Convert.ToString(levelMoney);

            collision.gameObject.SetActive(false);
        }

        //Destroy(gameObject);
        
    }
}
