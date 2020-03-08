using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDMovement : MonoBehaviour
{
    public CharacterController controller;

    public float moveSpd = 12f;
    public float gravity = -18f;
    public float jumpSpd = 2f;

    Vector3 velocity;

    public bool isGrounded;
    public static float fuel = 1000;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * moveSpd * Time.deltaTime);

        if (Input.GetButton("Jump") && fuel > 0)
        {
             velocity.y = Mathf.Sqrt(jumpSpd * -1f * gravity);
             fuel --;
                
        }

        

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

    public static void AddFuel(int value)
    {
        if (fuel < 1000)
        {
            fuel += value;

            if (fuel > 1000)
            {
                fuel = 1000;
            }

        }

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("Land!");
        }
    }

    private void OnCollisionExit(Collision other)
    {
        
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            Debug.Log("Wheee!");
        }

    }
}
