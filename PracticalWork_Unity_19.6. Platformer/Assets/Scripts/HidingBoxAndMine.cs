using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidingBoxAndMine : MonoBehaviour
{
    [Tooltip("Поле для Point Effector (Взрыв)")]
    [SerializeField] private PointEffector2D _effector;

    [Tooltip("Сила взрыва")]
    [SerializeField] private float forceExposion;

    private Rigidbody2D rbMine;

    private void Awake()
    {  
        rbMine = GetComponent<Rigidbody2D>();

        // Включаем режим Kynematic Ridgidbody, чтобы мина не падала
        rbMine.isKinematic = true;

        // Выключаем взрыв
        _effector.forceMagnitude = 0f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);

        // При падении меняется сила взрыва
        _effector.forceMagnitude = forceExposion;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // При соприкосновении игрока включается падение мины
            rbMine.isKinematic = false;
        }
    }
}
