using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float speed, timeToRevert;

    
    [SerializeField] private Animator anim;
    [SerializeField] private SpriteRenderer spriteRend;

    private Rigidbody2D ridbody;

    private const float _idleState = 0;
    private const float _walkState = 1;
    private const float _revetrState = 2;

    private float _currentState, currentTimeToRevert;

    // Start is called before the first frame update
    void Start()
    {
        _currentState = _walkState;
        currentTimeToRevert = 0;
        ridbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTimeToRevert >= timeToRevert)
        {
            currentTimeToRevert = 0;
            _currentState = _revetrState;
        }

        switch(_currentState)
        {
            case _idleState:
                currentTimeToRevert += Time.deltaTime;
                break;
            case _walkState:
                ridbody.velocity = Vector2.left * speed;
                break;
            case _revetrState:
                spriteRend.flipX = !spriteRend.flipX;
                speed *= -1;
                _currentState = _walkState;
                break;
        }
        anim.SetFloat("Velocity", ridbody.velocity.magnitude);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyStopper"))
        {
            _currentState = _idleState;
        }
    }
}
