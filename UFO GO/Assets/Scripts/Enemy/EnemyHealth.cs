using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 50;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {

            health = health - 10;
            Destroy(other.gameObject);
            if (health == 0) Destroy(gameObject);

        }
    }
}
