using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealler : MonoBehaviour
{
    // Урон от пули
    [SerializeField] private float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Damageable"))
        {
            // У объекта с которым столкнулись пули, вызывается скрипт "Health" и метод "TakeDamage" с параметром damage (Уменьшает здоровье)
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);

            // Удаляем пулю
            Destroy(gameObject);
        }


        //// Удаляем пулю
        //Destroy(gameObject);
    }
}
