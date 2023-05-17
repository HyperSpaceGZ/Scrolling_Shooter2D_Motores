using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollower : EnemyShip
{
    [SerializeField] private GameObject Player;
    [SerializeField] private float speed;

    [SerializeField] private bool hastriggered;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        hastriggered = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (hastriggered == false && collision.gameObject.tag == "Player")
        {
            hastriggered = true;
            InvokeRepeating("EnemyFollowerMovement", 0f, 0.03f);
        }
    }

    private void EnemyFollowerMovement()
    {
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed* Time.deltaTime);
    }


}
