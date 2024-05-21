using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageDealler : MonoBehaviour
{
    // ���� �� ����
    [SerializeField] private float damage;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Damageable"))
        {
            // � ������� � ������� ����������� ����, ���������� ������ "Health" � ����� "TakeDamage" � ���������� damage (��������� ��������)
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);
        }        

        // ������� ����
        Destroy(gameObject);
    }

    /// <summary>
    /// ������� �������� �����
    /// </summary>
    private void FillHealthImage()
    {
        _imgHP.fillAmount = currentHealth / maxHealth;
    }
}
