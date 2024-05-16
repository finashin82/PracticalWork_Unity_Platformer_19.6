using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MineExplosion : MonoBehaviour
{
    [Tooltip("����� (������).")]
    [SerializeField] private GameObject _explosion;

    [Tooltip("��� �������� ��������� ����.")]
    [SerializeField] private GameObject _mine;

    [Tooltip("��� ������� ������ �� �������.")]
    [SerializeField] private ParticleSystem _explosionPS;


    [SerializeField] private AudioSource _explosionClip;

    private bool isExplosion = false;
    private bool isPermission = true;

    // Update is called once per frame
    void Update()
    {
        // ������ ������ ������� �� �����
        _explosion.transform.position = _mine.transform.position;

        // ������� ������ ������� �� �����
        _explosionPS.transform.position = _mine.transform.position;

        if (_mine.activeSelf == false)
            isExplosion = true;
        
        // ���� ���� �������, �� ��������� ��� ������ �������� (��� ���������� ����� ����� �� ����������� �� ������ ����)
        // �.�. ����, ����� ������������ �� �����, �� ����� � ���� ����������� �� ���������
        if (isExplosion && isPermission)
        {
            // ����� ������
            _explosionPS.Play();

            // ���� ������
            _explosionClip.Play();

            // ������ ������ (��������)
            Instantiate(_explosion);

            // �������� ���������� � ������ ���� ��� ����������� �� �����
            isPermission = false;
        }        
    }
}
