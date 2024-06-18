using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathInGame : MonoBehaviour
{
    [SerializeField] private Health _player;

    private Animator animatorGamer;

    private void Awake()
    {
        animatorGamer = GetComponent<Animator>();
    }

    private void Update()
    {        
        // Если текущая жизнь меньше или равна 0, то запуск анимации и скрытие объекта
        if (!_player.IsAlive)
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
