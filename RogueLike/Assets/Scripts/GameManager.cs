using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int key;
    public int gem;

    public void AddKey(int amount)
    {
        key += amount;// Adds keys
        Debug.Log("Keys = "+ key); // Prints a message showing how many keys we have in inventory

    }
    
}
