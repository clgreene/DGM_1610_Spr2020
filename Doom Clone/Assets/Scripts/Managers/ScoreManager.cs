using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public static int score;
    public static int health = 100;
    public static int ammo = 10;
    public static int fuel = 1000;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void AddPoints(int value)
    {
        score += value;
        Debug.Log("Game Score: " + score);
    }

    public static void AddHealth(int value)
    {
        health += value;
        Debug.Log("Health:" + health);
    }

    public static void AddAmmo(int value)
    {
        ammo += value;
        Debug.Log("Ammo: " + ammo);
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
}
