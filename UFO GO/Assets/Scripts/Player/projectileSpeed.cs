using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileSpeed : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 300;
    public float spin = 20;
    public GameObject bullet;
    public int time = 1;

    void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
    }

    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
