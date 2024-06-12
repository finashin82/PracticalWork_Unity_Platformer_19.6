using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealler : MonoBehaviour
{
    // Урон от пули
    [SerializeField] private float damage;

    // Время, через которое уничтожается пуля
    private int timeToDestroy = 1;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Если у объекта есть скрипт с жизнью, то можем нанести ему урон
        if (collision.gameObject.GetComponent<Health>())
        {
            // У объекта с которым столкнулись пули, вызывается скрипт "Health" и метод "TakeDamage" с параметром damage (Уменьшает здоровье)
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);
        }               

        Coroutine coroutin = StartCoroutine(timer());
    }

    /// <summary>
    /// Вызываем уничтожение пули через определенное время
    /// </summary>
    /// <returns></returns>
    private IEnumerator timer()
    {        
        yield return new WaitForSeconds(timeToDestroy);
        Destroy(gameObject);        
    }
}
