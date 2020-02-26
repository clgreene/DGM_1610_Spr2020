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
    


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * moveSpd * Time.deltaTime);

        if (Input.GetButton("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpSpd * -1f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
