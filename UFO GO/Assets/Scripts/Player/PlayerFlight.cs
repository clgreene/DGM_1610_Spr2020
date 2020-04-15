using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlight : MonoBehaviour
{
    private Rigidbody rigid;

    public float gravity = -9f;
    public float jumpSpd = 50f;

    Vector3 velocity;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump") && (ScoreManager.fuel > 0))
        {
            rigid.AddForce(0, jumpSpd * Time.deltaTime, 0);
            ScoreManager.fuel--;
        }

        velocity.y += gravity * Time.deltaTime;

    }
}
