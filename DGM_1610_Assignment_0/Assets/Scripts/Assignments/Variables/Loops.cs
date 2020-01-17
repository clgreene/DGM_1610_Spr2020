using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    int enemies = 8;
    // Start is called before the first frame update
    void Start()
    {
        while (enemies > 0)
        {
            print("Master chief kills an enemy.");
            enemies--;
        }

        if (enemies == 0)
        {
            print("The Master Chief has killed all the covenant.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
