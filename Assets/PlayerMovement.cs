using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int movementspeed;
    public Rigidbody2D rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
}
