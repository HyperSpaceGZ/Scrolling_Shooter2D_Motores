using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelefeBossScript : EnemyShip
{
    [SerializeField] private GameObject EnemyBullet;
    [SerializeField] private GameObject Minion;

    [SerializeField] private Transform Spawner1;
    [SerializeField] private Transform Spawner2;
    [SerializeField] private Transform Spawner3;

    private bool hastriggered;

    void Start()
    {
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
            InvokeRepeating("BossShootingA", 10f, 1.5f);
            InvokeRepeating("BossShootingB", 10f, 1.5f);
            InvokeRepeating("BossShootingC", 10f, 1.5f);
            InvokeRepeating("BossMinionSpawn", 16f, 10f);
        }
    }

    private void BossShootingA()
    {
        GameObject bulletClone = Instantiate(EnemyBullet, Spawner1.position, Spawner1.rotation);
    }

    private void BossShootingB()
    {
        GameObject bulletClone = Instantiate(EnemyBullet, Spawner2.position, Spawner2.rotation);
    }

    private void BossShootingC()
    {
        GameObject bulletClone = Instantiate(EnemyBullet, Spawner3.position, Spawner3.rotation);
    }

    private void BossMinionSpawn()
    {
        GameObject MINION = Instantiate(Minion, Spawner1.position, Spawner1.rotation);
        GameObject MINION2 = Instantiate(Minion, Spawner2.position, Spawner2.rotation);
        GameObject MINION3 = Instantiate(Minion, Spawner3.position, Spawner3.rotation);
    }
}
