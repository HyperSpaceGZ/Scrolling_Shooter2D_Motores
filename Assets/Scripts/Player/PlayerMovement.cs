using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public int movementspeed;
    public int playerhealth;

    public GameObject Bullet;
    public GameObject BulletA;
    public GameObject BulletB;

    public Transform BulletSpawner;
    public Transform BulletSpawnerFire2A;
    public Transform BulletSpawnerFire2B;

    public float FireRate;
    private float NextFire;

    public TMP_Text HPText;

    void Start()
    {
        UIRefresh();
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemybullet") 
        {
            Hit();
        }
        else if (collision.gameObject.tag == "enemy")
        {
            Hit();
        }

        if (collision.gameObject.tag == "HP")
        {
            UIRefresh();
        }
    }

    private void Hit()
    {
        playerhealth--;
        UIRefresh();
    }
    private void UIRefresh()
    {
        HPText.text = "HP:" + playerhealth;
        if(playerhealth<1)
        {
            PlayerDeath();
        }
    }

    public void AddHP()
    {
        if (playerhealth < 10)
        {
            playerhealth++;
            UIRefresh();
        }
    }

    private void PlayerDeath()
    {
        SceneManager.LoadScene("Death");
    }

}
