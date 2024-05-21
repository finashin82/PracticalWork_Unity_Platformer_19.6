using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageToThePlayer : MonoBehaviour
{
    // Картинка для заливки HP
    [SerializeField] private Image _imgHP;

    // Максимальная жизнь
    [SerializeField] private float maxHealth;   

    // Текущая жизнь
    private float currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    // Урон от прикосновения игрока
    [SerializeField] private float damage;      

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // У объекта плеер, который столкнулся с врагом, вызывается скрипт "Health" и метод "TakeDamage" с параметром damage (Уменьшает здоровье)
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);

            FillHealthImage(); 
        }
    }

    /// <summary>
    /// Заливка картинки жизнь
    /// </summary>
    private void FillHealthImage()
    {
        _imgHP.fillAmount = currentHealth / maxHealth;
    }
}
