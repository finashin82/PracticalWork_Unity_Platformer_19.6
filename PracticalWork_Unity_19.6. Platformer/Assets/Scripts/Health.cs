using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    // ������������ �����
    [SerializeField] private float maxHealth;

    // ������� �����
    private float currentHealth;

    private float currentFill;

    private void Awake()
    {        
        currentHealth = maxHealth;        
    }

    /// <summary>
    /// ���� ������
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage) 
    {
        currentHealth -= damage;
    }

    /// <summary>
    /// ������� �����
    /// </summary>
    public float FillHealthImage()
    {
        currentFill = currentHealth / maxHealth;

        return currentFill;       
    }
}
