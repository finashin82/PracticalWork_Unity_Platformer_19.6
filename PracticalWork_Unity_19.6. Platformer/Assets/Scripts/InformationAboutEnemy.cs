using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationAboutEnemy : MonoBehaviour
{
    // ����
    [SerializeField] private GameObject _enemy;

    // Update is called once per frame
    void Update()
    {
        if (_enemy.gameObject.activeSelf == false)
        {
            //��������� �������� �������
            _enemy.transform.parent.gameObject.SetActive(false);

            //_enemy.SetActive(false);
        }
    }
}
