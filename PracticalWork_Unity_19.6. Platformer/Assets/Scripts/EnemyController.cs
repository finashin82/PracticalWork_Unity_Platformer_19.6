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

    private float _currentState, currentTimeToRevert;

    // Start is called before the first frame update
    void Start()
    {
        _currentState = (float)spriteState._walkState;
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
            _currentState = (float)spriteState._revetrState;
        }

        switch(_currentState)
        {
            case (float)spriteState._idleState:
                currentTimeToRevert += Time.deltaTime;
                break;
            case (float)spriteState._walkState:
                ridbody.velocity = Vector2.left * speed;
                break;
            case (float)spriteState._revetrState:
                spriteRend.flipX = !spriteRend.flipX;
                speed *= -1;
                _currentState = (float)spriteState._walkState;
                break;
        }
        anim.SetFloat("Velocity", ridbody.velocity.magnitude);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyStopper"))
        {
            _currentState = (float)spriteState._idleState;
        }
    }
}
