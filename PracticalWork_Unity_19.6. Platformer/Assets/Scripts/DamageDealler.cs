using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealler : MonoBehaviour
{
    // ���� �� ����
    [SerializeField] private float damage;

    // �����, ����� ������� ������������ ����
    private int timeToDestroy = 1;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ���� � ������� ���� ������ � ������, �� ����� ������� ��� ����
        if (collision.gameObject.GetComponent<Health>())
        {
            // � ������� � ������� ����������� ����, ���������� ������ "Health" � ����� "TakeDamage" � ���������� damage (��������� ��������)
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);
        }               

        Coroutine coroutin = StartCoroutine(timer());
    }

    /// <summary>
    /// �������� ����������� ���� ����� ������������ �����
    /// </summary>
    /// <returns></returns>
    private IEnumerator timer()
    {        
        yield return new WaitForSeconds(timeToDestroy);
        Destroy(gameObject);        
    }
}
