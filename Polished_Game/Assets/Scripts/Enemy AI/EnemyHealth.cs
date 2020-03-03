﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int currentHealth;
    public int maxHealth = 3;
    public Transform spawnPoint;
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        Debug.Log("Enemy Takes Damage");
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            print("You Killed an Enemy!");

            transform.position = spawnPoint.position;
            transform.rotation = spawnPoint.rotation;

            currentHealth = maxHealth;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
