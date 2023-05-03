using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovementSprite2 : MonoBehaviour
{
    public float BulletSpawnedTime = 0f;
    public float BulletDespawnTime = 3f;
    public float BulletSpeed = 100f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * BulletSpeed * Time.deltaTime);
        BulletSpawnedTime += Time.deltaTime;
        if (BulletSpawnedTime >= BulletDespawnTime)
        {
            Destroy(this.gameObject);
        }
    }
}
