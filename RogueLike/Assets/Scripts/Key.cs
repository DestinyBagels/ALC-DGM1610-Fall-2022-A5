using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Pickups
{

    private GameManager gm;


    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

        void OnTriggerEnter2D(Collider2D other)
    {
        //PIckup key
        if(other.gameObject.CompareTag("Player"))
        {
            gm.AddKey(amount); //Add pickup to inventory
            Destroy(gameObject); // Dstroy pickup

        }
    }

}
