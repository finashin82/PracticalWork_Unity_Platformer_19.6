using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Image _HPEnemyImage;

    [SerializeField] private float speed, timeToRevert;
    
    [SerializeField] private Animator anim;
    [SerializeField] private SpriteRenderer spriteRend;

    private Rigidbody2D ridbody;

    private enum spriteState
    {
        _idleState = 0,
        _walkState = 1,
        _revetrState = 2,
    }

    private spriteState _currentState;
    private float currentTimeToRevert;

    bool isPermissionAlive;

    private void Awake()
    {
        isPermissionAlive = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        _currentState = spriteState._walkState;
        currentTimeToRevert = 0;
        ridbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _HPEnemyImage.transform.position = new Vector2(spriteRend.transform.position.x, _HPEnemyImage.transform.position.y);

        if (currentTimeToRevert >= timeToRevert)
        {
            currentTimeToRevert = 0;
            _currentState = spriteState._revetrState;
        }

        // ≈сли враг убит, скорость = 0, чтобы не двигалс€ после смерти
        if (!isPermissionAlive)
        {
            speed = 0;
        }

        switch(_currentState)
        {
            case spriteState._idleState:
                currentTimeToRevert += Time.deltaTime;
                break;
            case spriteState._walkState:
                ridbody.velocity = Vector2.left * speed;
                break;
            case spriteState._revetrState:
                spriteRend.flipX = !spriteRend.flipX;
                speed *= -1;
                _currentState = spriteState._walkState;
                break;
        }
        anim.SetFloat("Velocity", ridbody.velocity.magnitude);
    }

    /// <summary>
    /// «апрет движени€ после смерти
    /// </summary>
    /// <param name="health"></param>
    public void PermissionIsAlive(Health health)
    {
        isPermissionAlive = health.IsAlive; 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyStopper"))
        {
            _currentState = spriteState._idleState;
        }
    }
}
