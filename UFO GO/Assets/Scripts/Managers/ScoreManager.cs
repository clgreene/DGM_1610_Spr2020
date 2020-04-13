using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager: MonoBehaviour
{

    public static int score;
    public static int health = 100;
    public static int ammo = 10;
    public static int fuel = 0;

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
        fuel += value;
        Debug.Log("Fuel: " + fuel);
    }
}
