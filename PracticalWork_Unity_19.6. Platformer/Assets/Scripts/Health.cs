using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    // Максимальная жизнь
    [SerializeField] private float maxHealth;

    // Текущая жизнь
    private float currentHealth;

    private float currentFill;

    private void Awake()
    {        
        currentHealth = maxHealth;        
    }

    /// <summary>
    /// Урон игроку
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage) 
    {
        currentHealth -= damage;
    }

    /// <summary>
    /// Текущая жизнь
    /// </summary>
    public float FillHealthImage()
    {
        currentFill = currentHealth / maxHealth;

        return currentFill;       
    }
}
