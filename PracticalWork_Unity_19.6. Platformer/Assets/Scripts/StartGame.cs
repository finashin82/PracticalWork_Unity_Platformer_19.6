using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public void StartGames()
    {
        PlayerPrefs.SetInt("allCoin", 0);
        PlayerPrefs.SetInt("levelCoin", 0);
    }
}
