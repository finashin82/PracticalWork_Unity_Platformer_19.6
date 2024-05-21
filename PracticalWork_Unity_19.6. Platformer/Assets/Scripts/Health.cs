using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Health : MonoBehaviour
{ 
    // ������� �����
    private float currentHealth;   

    private Animator animatorGamer;

    private void Awake()
    {
        animatorGamer = GetComponent<Animator>();       
    }

    /// <summary>
    /// ���� ������
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage) 
    {
        currentHealth -= damage;

        CheckIsAlive();
    }

    /// <summary>
    /// ��� �� �����
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
        // �������� �������� ����� 2 �������
        yield return new WaitForSeconds(0.5f);

        gameObject.SetActive(false);
    }
}
