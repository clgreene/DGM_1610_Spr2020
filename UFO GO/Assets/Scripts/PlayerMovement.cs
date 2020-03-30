using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 800f;
    public float strafe = 9000f;
    public Transform player;

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
            

        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-strafe * Time.deltaTime, 0, 0);

        }
    }
}
