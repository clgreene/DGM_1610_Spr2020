using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileSpeed : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 90;
    public float spin = 20;
    public GameObject bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
    }
}
