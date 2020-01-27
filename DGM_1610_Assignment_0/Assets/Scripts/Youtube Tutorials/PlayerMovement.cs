﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float playerSpeed = 1000f;
    public float playerStrafe = 60f;

    // Start is called before the first frame update
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, playerSpeed * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(playerStrafe * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-playerStrafe * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    
    }
}
