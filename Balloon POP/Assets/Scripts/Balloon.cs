using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive = 100; // score give for popped balloon.

    public int clickToPop = 2; //How many clicks before balloon pops

    public float scaleToIncrease = 0.10f; //scale increase each time the balloon is clicked

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        //reduce clicks by one
        clickToPop -= 1;
        //increase
        transform.localScale += Vector3.one * scaleToIncrease;

        if(clickToPop == 0)
        {
            Destroy(gameObject);
        }
    }

}
