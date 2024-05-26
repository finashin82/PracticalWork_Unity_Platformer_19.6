using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //public TakingCoin takingCoin;

    //public int levelCoin;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //takingCoin.levelCoin += 1;
            gameObject.SetActive(false);
        }
    }
}
