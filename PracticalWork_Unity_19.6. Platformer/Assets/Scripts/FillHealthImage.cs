using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillHealthImage : MonoBehaviour
{
    // Картинка для показа жизни
    [SerializeField] private Image _imageHP;

    // Объект, для которого показывается жизнь
    [SerializeField] private GameObject _player;

    private float currentFill;

    void Update()
    {
        currentFill = _player.GetComponent<Health>().FillHealthImage();

        _imageHP.fillAmount = currentFill;
    }
}
