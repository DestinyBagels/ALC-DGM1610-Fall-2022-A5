using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; // How fast the player moves
    
    public float hInput; // Horizontal Input
    public float vInput; // Vertical Input

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.Translate(Vector2.right * hInput * speed * Time.deltaTime); // Moves the player left and right
        transform.Translate(Vector2.up * vInput * speed * Time.deltaTime); // Moves the player up and down
        
    }
}
