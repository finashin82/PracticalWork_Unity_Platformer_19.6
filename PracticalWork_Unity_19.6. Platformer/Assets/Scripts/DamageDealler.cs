using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageDealler : MonoBehaviour
{
    // Урон от пули
    [SerializeField] private float damage;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Damageable"))
        {
            // У объекта с которым столкнулись пули, вызывается скрипт "Health" и метод "TakeDamage" с параметром damage (Уменьшает здоровье)
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);
        }        

        // Удаляем пулю
        Destroy(gameObject);
    }

    /// <summary>
    /// Заливка картинки жизнь
    /// </summary>
    private void FillHealthImage()
    {
        _imgHP.fillAmount = currentHealth / maxHealth;
    }
}
