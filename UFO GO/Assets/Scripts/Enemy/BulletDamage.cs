using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{

    public int value;
    public int hit = 0;
    public int time = 3;

    private void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    public void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.tag == "Player") && (hit == 0))
        {
            ScoreManager.AddHealth(value);
            hit = 1;
            Destroy(gameObject);
        }

    }

    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
