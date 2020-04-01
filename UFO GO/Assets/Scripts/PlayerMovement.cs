using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 900f;
    public float strafe = 90f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Pushing UFO forward and outlining strafing movement
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(strafe * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-strafe * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
    }
}
