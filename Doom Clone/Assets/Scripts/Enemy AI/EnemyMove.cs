using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public GameObject player;
    public Transform target;
    public float moveSpeed = 1;
    public Vector3 targetV;
    public Vector3 current;
    public float close;
    public float minDist = 20;
    //private Rigidbody enemyRb;

    // Start is called before the first frame update
    void Start()
    {
        //storing "players" position at begining of enemy creation in target
        //enemyRb = GetComponent<Rigidbody>();
        //player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        targetV = GameObject.Find("Player Character").transform.position;
        current = transform.position;
        target = GameObject.Find("Player Character").transform;
        close = Vector3.Distance(targetV, current);

        while (close < minDist)
        {
            //point enemy at player
            transform.LookAt(target);
            //move enemy forward
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        
        
    }

    private void FixedUpdate()
    {
        //change velocity
        //enemyRb.velocity = player * moveSpeed;

        //Add Force
        //enemyRb.AddForce((player.transform.position - transform.position).normalized * moveSpeed);

        //MovePosition
        //enemyRb.MovePosition((player.transform.position - transform.position).normalized * moveSpeed);


    }
}
