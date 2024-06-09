using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class InformationAboutPlayer : MonoBehaviour
{
    // ���� ��� ������ ������ ������
    [SerializeField] private Text _levelNumber;   
                
    // Player
    [SerializeField] private GameObject _player;

    // ���� ��� "������ �����"
    [SerializeField] private GameObject _pausePanel;

    // ���� ��� "������ GameOver"
    [SerializeField] private GameObject _gameOverPanel;

    private bool isAction;

    private void Awake()
    {
        isAction = true;

        _levelNumber.text = "������� " + SceneManager.GetActiveScene().buildIndex.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (_player.gameObject.activeSelf == false)
        {
            //Time.timeScale = 0;
            _gameOverPanel.SetActive(true);
            
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //_player.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isAction) 
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
            _pausePanel.gameObject.SetActive(isAction);
            isAction = !isAction;
        }

    }
}
