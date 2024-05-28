using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InformationAboutPlayer : MonoBehaviour
{
    [SerializeField] private Text _levelNumber;
   

    //// Окно при убийстве врага
    //[SerializeField] private Image _textWinImage;

    //// Окно при проигрыше Player
    //[SerializeField] private Image _textLostPlayerImage;

    //// Враг
    //[SerializeField] private GameObject _enemy;

    //// Player
    //[SerializeField] private GameObject _player;

    private bool isAlive;

    private void Awake()
    {
        _levelNumber.text = "Уровень " + SceneManager.GetActiveScene().buildIndex.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //if (_enemy.activeSelf == false)
        //{
        //    _textWinImage.gameObject.SetActive(true);
        //}

        //if (_player.activeSelf == false)
        //{
        //    _textLostPlayerImage.gameObject.SetActive(true);
        //}

        
    }
}
