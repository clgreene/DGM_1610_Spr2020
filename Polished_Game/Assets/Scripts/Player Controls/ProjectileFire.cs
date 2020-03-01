using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFire : MonoBehaviour
{
    // Start is called before the first frame update

    

    public GameObject projectilePrefab;
    void Start()
    {
        
    }
       
    // Update is called once per frame
    void Update()
    {
        //if (ammo > 0)
        //{
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(projectilePrefab, transform.position + transform.forward, transform.rotation);
                //ammo -= 1;
            }
        //}
    }
}
