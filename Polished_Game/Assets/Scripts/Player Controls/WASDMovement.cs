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
    public float fuel = 1000;

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

        if (isGrounded == true && fuel < 1000)
        {
            fuel ++;
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
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
