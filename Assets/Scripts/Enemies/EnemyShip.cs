using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet" && health > 0)
        {
            health--;
        }
        else if (health == 0)
        {
            EnemyDeath();
        }

    }
    private void EnemyDeath()
    {
        Destroy(this.gameObject);
    }
}

