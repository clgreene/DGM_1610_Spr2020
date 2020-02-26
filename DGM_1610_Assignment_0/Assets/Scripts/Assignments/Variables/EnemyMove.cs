using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public GameObject player;
    public Transform target;
    public float moveSpeed = 1;
    //private Rigidbody enemyRb;

    // Start is called before the first frame update
    void Start()
    {
        //storing "players" position at begining of enemy creation in target
        target = GameObject.Find("PlayerCharacter").transform;


        //enemyRb = GetComponent<Rigidbody>();
        //player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //point enemy at player
        transform.LookAt(target);
        //move enemy forward
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
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
