using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGames()
    {
        PlayerPrefs.SetInt("allCoin", 0);
        PlayerPrefs.SetInt("levelCoin", 0);
    }
}
