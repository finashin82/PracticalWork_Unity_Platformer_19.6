using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelectionLevel : MonoBehaviour
{
    private PlayerSelectionMenu playerSelection;

    private bool w;

    // Start is called before the first frame update
    void Start()
    {
        playerSelection = GetComponent<PlayerSelectionMenu>();
        w = playerSelection.;
        //isSoldier = playerSelection.GetComponent<PlayerSelectionMenu>.isSoldier;

        if (w)
            Debug.Log("Soldier");
        else
            Debug.Log("Mercwenary");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
