using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageToThePlayer : MonoBehaviour
{
    // �������� ��� ������� HP
    [SerializeField] private Image _imgHP;

    // ������������ �����
    [SerializeField] private float maxHealth;   

    // ������� �����
    private float currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    // ���� �� ������������� ������
    [SerializeField] private float damage;      

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // � ������� �����, ������� ���������� � ������, ���������� ������ "Health" � ����� "TakeDamage" � ���������� damage (��������� ��������)
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);

            FillHealthImage(); 
        }
    }

    /// <summary>
    /// ������� �������� �����
    /// </summary>
    private void FillHealthImage()
    {
        _imgHP.fillAmount = currentHealth / maxHealth;
    }
}
