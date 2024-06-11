using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    // Update is called once per frame
    void Update()
    {
        //repeatLevel = GetComponent<LevelTransition>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _player.gameObject.SetActive(false);            
        }
    }
}
