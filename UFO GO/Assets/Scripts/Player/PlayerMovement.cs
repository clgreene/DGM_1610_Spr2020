using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 200f;
    public float speed = 25f;
    public float strafe = 90f;
    public Transform trans;

    

    // Start is called before the first frame update
    void Start()
    {
        trans = GetComponent<Transform>();
    }

    // Pushing UFO forward and outlining strafing movement
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        /*if (transform.position.z < 50)
            {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 
            }*/

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
