using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Pickups
{

    public int healthAmt = 100;

    // Start is called before the first frame update
    void Start()
    {
        print("Health: " + healthAmt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerCharacter"))
        {

            ScoreManager.AddHealth(value);
            Destroy(gameObject);

        }
    }
}
