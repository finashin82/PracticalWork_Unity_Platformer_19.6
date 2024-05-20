using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelectionMenu : MonoBehaviour
{
    [Tooltip("soldier")]
    [SerializeField] private Image _soldierPlayer;

    [Tooltip("mercenary")]
    [SerializeField] private Image _mercenaryPlayer;

    private void Awake()
    {
        _soldierPlayer.color = Color.white;
       
        _mercenaryPlayer.color = Color.black;
       
        PlayerPrefs.SetInt("soldierSelection", 1);
    }
   
    /// <summary>
    ///  нопка выбора солдата
    /// </summary>
    public void SoldierSelectionButton()
    {
        _soldierPlayer.color = Color.white;
       
        _mercenaryPlayer.color = Color.black;
      
        PlayerPrefs.SetInt("soldierSelection", 1);
    }

    /// <summary>
    ///  нопка выбора наемника
    /// </summary>
    public void MercenarySelectionButton()
    {
        _soldierPlayer.color = Color.black;
      
        _mercenaryPlayer.color = Color.white;
       
        PlayerPrefs.SetInt("soldierSelection", 0);
    }
}
