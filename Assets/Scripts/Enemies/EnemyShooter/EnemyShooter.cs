using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : EnemyShip
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject EnemyBullet;
    [SerializeField] private Transform EnemyBulletSpawner;
    // Start is called before the first frame update
    void Start()
    {
        EnemyBulletSpawner = this.gameObject.transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            InvokeRepeating("EnemyShooterMovement", 0f, 0.01f);
            InvokeRepeating("EnemyShooterShooting", 3.5f, 2f);
        }
    }

    private void EnemyShooterMovement()
    {
        transform.position -= new Vector3(0, speed * (Time.deltaTime), 0);
    }

    private void EnemyShooterShooting()
    {
        GameObject bulletClone = Instantiate(EnemyBullet, EnemyBulletSpawner.position, EnemyBulletSpawner.rotation);
    }
}
