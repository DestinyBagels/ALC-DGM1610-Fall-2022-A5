using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{

    public float moveSpeed = 5.0f;
    public float upperBound = 25.0f;
    private Balloon balloon;

    // Start is called before the first frame update
    void Start()
    {
        balloon = GetComponent<Balloon>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move the balloon upward
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        //Destroy Balloon after it passes upperbound
        if(transform.position.y > upperBound)
        {
            Destroy(gameObject); // POP balloon

        }
    }
}
