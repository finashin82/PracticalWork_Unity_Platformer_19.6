using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidingBoxAndMine : MonoBehaviour
{
    [Tooltip("���� ��� Point Effector (�����)")]
    [SerializeField] private PointEffector2D _effector;

    [Tooltip("���� ������")]
    [SerializeField] private float forceExposion;

    private Rigidbody2D rbMine;

    private void Awake()
    {  
        rbMine = GetComponent<Rigidbody2D>();

        // �������� ����� Kynematic Ridgidbody, ����� ���� �� ������
        rbMine.isKinematic = true;

        // ��������� �����
        _effector.forceMagnitude = 0f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);

        // ��� ������� �������� ���� ������
        _effector.forceMagnitude = forceExposion;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // ��� ��������������� ������ ���������� ������� ����
            rbMine.isKinematic = false;
        }
    }
}
