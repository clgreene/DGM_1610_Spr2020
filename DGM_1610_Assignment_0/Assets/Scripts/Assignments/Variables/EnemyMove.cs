using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public Transform target;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //storing "players" position at begining of enemy creation in target
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //point enemy at player
        transform.LookAt(target);
        //move enemy forward
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
