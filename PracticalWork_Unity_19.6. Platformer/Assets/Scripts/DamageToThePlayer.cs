using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToThePlayer : MonoBehaviour
{
    // Урон от прикосновения игрока
    [SerializeField] private float damage;      

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // У объекта плеер, который столкнулся с врагом, вызывается скрипт "Health" и метод "TakeDamage" с параметром damage (Уменьшает здоровье)
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
