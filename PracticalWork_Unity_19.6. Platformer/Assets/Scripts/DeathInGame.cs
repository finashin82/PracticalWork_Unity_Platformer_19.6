using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathInGame : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    private Animator animatorGamer;

    private float currentFill;

    private void Awake()
    {
        animatorGamer = GetComponent<Animator>();
    }

    private void Update()
    {
        currentFill = _player.GetComponent<Health>().FillHealthImage();

        // Если текущая жизнь меньше или равна 0, то запуск анимации и скрытие объекта
        if (currentFill <= 0)
        {
            animatorGamer.SetBool("isDeath", true);

            Coroutine coroutin = StartCoroutine(timer());
        }
    }

    // Исчезновение объекта после смерти
    private IEnumerator timer()
    {
        // Вызывает действие через 2 секунды
        yield return new WaitForSeconds(0.5f);

        gameObject.SetActive(false);
    }
}
