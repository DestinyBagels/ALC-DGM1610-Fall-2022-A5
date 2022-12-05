using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeBase : MonoBehaviour
{

    pirvate GameObject flag;
    private GameManager gm;


    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collision other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Player has reached Homebase!")
            gm.PlaceFlag();
            flag.SetActive(true);
        }
    }
}
