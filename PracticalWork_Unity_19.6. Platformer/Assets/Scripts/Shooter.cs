using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    // ��� ����� �������� �����
    [SerializeField] private GameObject _bullet;

    // �������� ��������
    [SerializeField] private float fireSpeed;

    [SerializeField] private Transform firePoint;

    /// <summary>
    /// ��������, direction - �����������
    /// </summary>
    /// <param name="direction"></param>
    public void Shoot(float direction)
    {
        // ������� ������, ������� ����� ��������. Quaternion.identity - ��� ��������
        GameObject currentBullet = Instantiate(_bullet, firePoint.position, Quaternion.identity);
        Rigidbody2D currentBulletVelocity = currentBullet.GetComponent<Rigidbody2D>();

        if(direction >= 0)
        {
            currentBulletVelocity.velocity = new Vector2(fireSpeed * 1, currentBulletVelocity.velocity.y);
        }
        else
        {
            currentBulletVelocity.velocity = new Vector2(fireSpeed * -1, currentBulletVelocity.velocity.y);
        }
    }
}
