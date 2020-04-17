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
        if (Input.GetKeyDown(KeyCode.LeftShift) && (ScoreManager.ammo > 0))
        {
            Instantiate(projectilePrefab, transform.position + transform.forward, transform.rotation);
            ScoreManager.ammo--;
        }
    }
}
