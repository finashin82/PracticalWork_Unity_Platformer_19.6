using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelectionLevel : MonoBehaviour
{
    [Tooltip("soldier")]
    [SerializeField] private GameObject _soldierPlayer;

    [Tooltip("mercenary")]
    [SerializeField] private GameObject _mercenaryPlayer;

    private void Awake()
    {
        if(PlayerPrefs.GetInt("soldierSelection") == 1 )
        {
            _soldierPlayer.gameObject.SetActive(true);
            _mercenaryPlayer.gameObject.SetActive(false);
        }
        else
        {
            _soldierPlayer.gameObject.SetActive(false);
            _mercenaryPlayer.gameObject.SetActive(true);
        }
    }   
}
