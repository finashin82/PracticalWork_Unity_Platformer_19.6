using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillHealthImage : MonoBehaviour
{
    // �������� ��� ������ �����
    [SerializeField] private Image _imageHP;

    // ������, ��� �������� ������������ �����
    [SerializeField] private Health _player;

    private float currentFill;

    void Update()
    {
        currentFill = _player.CurrentHealth / _player.MaxHealth;

        _imageHP.fillAmount = currentFill;
    }
}
