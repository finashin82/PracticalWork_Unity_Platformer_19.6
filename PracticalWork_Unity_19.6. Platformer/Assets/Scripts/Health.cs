using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    // Картинка для заливки HP
    [SerializeField] private Image _imgHP;    

    // Максимальная жизнь
    [SerializeField] private float maxHealth;

    // Текущая жизнь
    private float currentHealth;

    // Жив игрок или нет
    private bool isAlive;

    private Animator animatorGamer;

    private void Awake()
    {
        animatorGamer = GetComponent<Animator>();
        currentHealth = maxHealth;
        isAlive = true;
    }

    /// <summary>
    /// Урон игроку
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage) 
    {
        currentHealth -= damage;

        FillHealthImage();

        CheckIsAlive();
    }

    /// <summary>
    /// Жив ли игрок
    /// </summary>
    private void CheckIsAlive()
    {
        if (currentHealth > 0)
        {
            isAlive = true;            
        }
        else
        {
            animatorGamer.SetBool("isDeath", true);

            Coroutine coroutin = StartCoroutine(timer());
        }
    }

    /// <summary>
    /// Заливка картинки жизнь
    /// </summary>
    private void FillHealthImage()
    {
        _imgHP.fillAmount = currentHealth / maxHealth;
    }

    private IEnumerator timer()
    {
        // Вызывает действие через 2 секунды
        yield return new WaitForSeconds(0.5f);

        gameObject.SetActive(false);
    }
}
