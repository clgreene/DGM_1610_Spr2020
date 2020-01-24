using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDMovement : MonoBehaviour
{
    float moveSpd = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, moveSpd);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-moveSpd, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -moveSpd);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(moveSpd, 0, 0);
        }
    }
}
