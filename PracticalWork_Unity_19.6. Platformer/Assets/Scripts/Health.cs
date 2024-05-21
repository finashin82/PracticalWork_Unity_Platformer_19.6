using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Health : MonoBehaviour
{ 
    // Текущая жизнь
    private float currentHealth;   

    private Animator animatorGamer;

    private void Awake()
    {
        animatorGamer = GetComponent<Animator>();       
    }

    /// <summary>
    /// Урон игроку
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage) 
    {
        currentHealth -= damage;

        CheckIsAlive();
    }

    /// <summary>
    /// Жив ли игрок
    /// </summary>
    private void CheckIsAlive()
    {
        if (currentHealth <= 0)
        {
            animatorGamer.SetBool("isDeath", true);

            Coroutine coroutin = StartCoroutine(timer());
        }    
    }   

    private IEnumerator timer()
    {
        // Вызывает действие через 2 секунды
        yield return new WaitForSeconds(0.5f);

        gameObject.SetActive(false);
    }
}
