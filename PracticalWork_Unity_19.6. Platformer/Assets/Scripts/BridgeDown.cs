using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeDown : MonoBehaviour
{
    private Rigidbody2D rigidBodyBridge;

    // Start is called before the first frame update
    void Start()
    {
        rigidBodyBridge = GetComponent<Rigidbody2D>();
        rigidBodyBridge.isKinematic = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(BridgeIsKinematic());
    }

    IEnumerator BridgeIsKinematic() 
    {
        yield return new WaitForSeconds(.2f);
        rigidBodyBridge.isKinematic = false;
    }
}
