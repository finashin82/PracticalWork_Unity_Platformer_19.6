using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToThePlayer : MonoBehaviour
{
    // ���� �� ������������� ������
    [SerializeField] private float damage;      

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // � ������� �����, ������� ���������� � ������, ���������� ������ "Health" � ����� "TakeDamage" � ���������� damage (��������� ��������)
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
