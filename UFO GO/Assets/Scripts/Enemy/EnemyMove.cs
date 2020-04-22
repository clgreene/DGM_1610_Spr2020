using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public Rigidbody rbfollow;
    public int distance;
    public Transform player;
    public float dist;
    public float speed = 80;
    public int time = 1;
    public int wait = 1;
    public GameObject bullet;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        dist = Vector3.Distance(player.position, transform.position);


        if (dist > 25)
        {
            transform.position = new Vector3(rbfollow.worldCenterOfMass.x, 2, distance);
        }

        else if (dist < 25)
        {
            Debug.Log("Too Close");
            transform.position = new Vector3(rbfollow.worldCenterOfMass.x, 2, rbfollow.worldCenterOfMass.z + 25);

            if (wait == 1)
            {
                wait = 0;
                StartCoroutine(FireBullet());
            }
            
        }
    }

    IEnumerator FireBullet()
    {
        yield return new WaitForSeconds(time);
        Instantiate(bullet, transform.position + transform.forward, transform.rotation);
        wait = 1;
    }
}
