using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelectionMenu : MonoBehaviour
{
    [SerializeField] private Image _soldierPlayer;

    [SerializeField] private Image _mercenaryPlayer;

    static public bool isSoldier;
    static public bool isMercenary;

    // Start is called before the first frame update
    void Start()
    {
        _soldierPlayer.color = Color.white;
        isSoldier = true;

        _mercenaryPlayer.color = Color.black;
        isMercenary = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SoldierSelection()
    {
        _soldierPlayer.color = Color.white;
        isSoldier = true;

        _mercenaryPlayer.color = Color.black;
        isMercenary = false;
    }

    public void MercenarySelection()
    {
        _soldierPlayer.color = Color.black;
        isSoldier = false;

        _mercenaryPlayer.color = Color.white;
        isMercenary = true;        
    }
}
