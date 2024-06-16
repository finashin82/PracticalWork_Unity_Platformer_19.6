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

        // ���� ������� ����� ������ ��� ����� 0, �� ������ �������� � ������� �������
        if (currentFill <= 0)
        {
            animatorGamer.SetBool("isDeath", true);

            Coroutine coroutin = StartCoroutine(timer());
        }
    }

    // ������������ ������� ����� ������
    private IEnumerator timer()
    {
        // �������� �������� ����� 2 �������
        yield return new WaitForSeconds(0.5f);

        gameObject.SetActive(false);
    }
}
