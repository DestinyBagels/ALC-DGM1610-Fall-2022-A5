 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed;
    private Transform player;
    private Vector2 target;
    public int damage;
    public Health playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.Find("Player").GetComponent<Health>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        target = new Vector2(player.position.x, player.position.y);
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime); 

       if(transform.position.x == target.x && transform.position.y == target.y)
       {
           Destroy(gameObject);
       }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Walls"))
        {
            DestroyProjectile();
        }
        if(other.CompareTag("Player"))
        {
            playerHealth.TakeDamage(damage);
            Destroy(gameObject);

        }
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}