using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    // ���� �� ����
    [SerializeField] private float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ���� � ������� ���� ������ � ������, �� ����� ������� ��� ����
        if (collision.gameObject.GetComponent<Health>())
        {
            // � ������� � ������� ����������� ����, ���������� ������ "Health" � ����� "TakeDamage" � ���������� damage (��������� ��������)
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
