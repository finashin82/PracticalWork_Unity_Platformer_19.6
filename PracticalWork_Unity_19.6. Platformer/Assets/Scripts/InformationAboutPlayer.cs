using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationAboutPlayer : MonoBehaviour
{
    // ���� ��� �������� �����
    [SerializeField] private Image _textWinImage;

    // ���� ��� ��������� Player
    [SerializeField] private Image _textLostPlayerImage;

    // ����
    [SerializeField] private GameObject _enemy;

    // Player
    [SerializeField] private GameObject _player;

    private bool isAlive;

    // Update is called once per frame
    void Update()
    {
        if (_enemy.activeSelf == false)
        {
            _textWinImage.gameObject.SetActive(true);
        }

        if (_player.activeSelf == false)
        {
            _textLostPlayerImage.gameObject.SetActive(true);
        }
    }
}
