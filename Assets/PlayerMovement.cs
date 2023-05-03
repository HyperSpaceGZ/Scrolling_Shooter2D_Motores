using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int movementspeed;

    public GameObject Bullet;
    public GameObject BulletA;
    public GameObject BulletB;

    public Transform BulletSpawner;
    public Transform BulletSpawnerFire2A;
    public Transform BulletSpawnerFire2B;

    public float FireRate;
    private float NextFire;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetAxis("Fire1") != 0)
        {
            Fire1();
        }

        if (Input.GetAxis("Fire2") != 0)
        {
            Fire2();
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            PlayerMovementX();
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            PlayerMovementY();
        }

    }

    private void PlayerMovementX()
    {
        float horizontalinput = Input.GetAxis("Horizontal") * movementspeed * Time.deltaTime;
        transform.Translate(horizontalinput, 0f, 0f);
    }

    private void PlayerMovementY()
    {
        float verticallinput = Input.GetAxis("Vertical") * movementspeed * Time.deltaTime;
        transform.Translate(0f, verticallinput, 0f);
    }

    private void Fire1()
    {
        if(Time.time > NextFire)
        {
            NextFire = Time.time + FireRate;
            GameObject bulletClone = Instantiate(Bullet, BulletSpawner.position, BulletSpawner.rotation);
        }
    }

    private void Fire2()
    {
        if (Time.time > NextFire)
        {
            NextFire = Time.time + FireRate;
            GameObject bulletCloneA = Instantiate(BulletA, BulletSpawnerFire2A.position, BulletSpawner.rotation);
            GameObject bulletCloneB = Instantiate(BulletB, BulletSpawnerFire2B.position, BulletSpawner.rotation);
        }
    }
}
