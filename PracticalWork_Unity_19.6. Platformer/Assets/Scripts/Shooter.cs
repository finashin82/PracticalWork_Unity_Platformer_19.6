using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    // Чем будет стрелять игрок
    [SerializeField] private GameObject _bullet;

    // Скорость стрельбы
    [SerializeField] private float fireSpeed;

    [SerializeField] private Transform firePoint;

    /// <summary>
    /// Стрельба, direction - направление
    /// </summary>
    /// <param name="direction"></param>
    public void Shoot(float direction)
    {
        // Создаем объект, которым будем стрелять. Quaternion.identity - без вращения
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
