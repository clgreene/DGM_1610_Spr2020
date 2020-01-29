using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public Transform obstacle;
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        if (obstacle.position.x > 4)
        {
            rb.AddForce(-300 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (obstacle.position.x < -4)
        {
            rb.AddForce(300 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
