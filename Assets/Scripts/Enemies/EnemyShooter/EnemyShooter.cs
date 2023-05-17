using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : EnemyShip
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject EnemyBullet;
    [SerializeField] private Transform EnemyBulletSpawner;

    [SerializeField] private bool hastriggered;
    // Start is called before the first frame update
    void Start()
    {
        EnemyBulletSpawner = this.gameObject.transform.GetChild(0);
        hastriggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (hastriggered == false && collision.gameObject.tag == "Player")
        {
            hastriggered = true;
            InvokeRepeating("EnemyShooterMovement", 0f, 0.01f);
            InvokeRepeating("EnemyShooterShooting", 3.5f, 2f);
            InvokeRepeating("Despawn", 20f, 1f);
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

    private void Despawn()
    {
        Destroy(this.gameObject);
    }
}
