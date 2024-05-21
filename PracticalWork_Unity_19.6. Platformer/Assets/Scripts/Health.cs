using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    // �������� ��� ������� HP
    [SerializeField] private Image _imgHP;    

    // ������������ �����
    [SerializeField] private float maxHealth;

    // ������� �����
    private float currentHealth;

    // ��� ����� ��� ���
    private bool isAlive;

    private Animator animatorGamer;

    private void Awake()
    {
        animatorGamer = GetComponent<Animator>();
        currentHealth = maxHealth;
        isAlive = true;
    }

    /// <summary>
    /// ���� ������
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage) 
    {
        currentHealth -= damage;

        FillHealthImage();

        CheckIsAlive();
    }

    /// <summary>
    /// ��� �� �����
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
    /// ������� �������� �����
    /// </summary>
    private void FillHealthImage()
    {
        _imgHP.fillAmount = currentHealth / maxHealth;
    }

    private IEnumerator timer()
    {
        // �������� �������� ����� 2 �������
        yield return new WaitForSeconds(0.5f);

        gameObject.SetActive(false);
    }
}
