using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables_1 : MonoBehaviour
{
    // Declare a variable AND initialize it. Declaring and Initializing are separate actions, even if performed in the same line of code.

    public int amount;
    public float money;
    public float cost;

    // Start is called before the first frame update
    void Start()
    {
        Calculate(amount, money, cost);
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Calculate(int amount, float money, float cost)
    {
        float total;
        total = money - amount * cost;
        print(total);
    }
    void CheckScore()
    {
        print("Sup Dawgz");
    }
}
