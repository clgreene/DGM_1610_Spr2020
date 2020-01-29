using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            movement.enabled = false;
            FindObjectOfType<GameMan>().EndGame();
        }
    }
}
