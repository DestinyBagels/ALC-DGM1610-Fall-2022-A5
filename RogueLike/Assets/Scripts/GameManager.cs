using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int key;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddKey()
    {
        key += amount;// Adds keys
        Debug.Log("Keys = "+ key); // Prints a message showing how many keys we have in inventory

    }
}
