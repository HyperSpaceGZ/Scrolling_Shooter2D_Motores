using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovementEnemy : MonoBehaviour
{
    [SerializeField] private float EnemyBulletSpawnedTime = 0f;
    [SerializeField] private float EnemyBulletDespawnTime = 3f;
    [SerializeField] private float EnemyBulletSpeed = 100f;
    void Update()
    {
        transform.Translate(Vector2.up * EnemyBulletSpeed * Time.deltaTime);
        EnemyBulletSpawnedTime += Time.deltaTime;
        if (EnemyBulletSpawnedTime >= EnemyBulletDespawnTime)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            DestroyEnemyEnemyBullet();
        }
    }

    private void DestroyEnemyEnemyBullet()
    {
        Destroy(this.gameObject);
    }
}
