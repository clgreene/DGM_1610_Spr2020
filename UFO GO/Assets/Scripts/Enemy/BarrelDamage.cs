using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelDamage : MonoBehaviour
{

    public int value;
    public int hit = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    public void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.tag == "Player") && (hit == 0))
        {
            ScoreManager.AddHealth(value);
            hit = 1;
        }

    }

}
