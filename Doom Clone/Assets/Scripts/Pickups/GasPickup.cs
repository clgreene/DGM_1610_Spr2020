using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasPickup : Pickups
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.AddFuel(value);
            Destroy(gameObject);
        }
    }
}
