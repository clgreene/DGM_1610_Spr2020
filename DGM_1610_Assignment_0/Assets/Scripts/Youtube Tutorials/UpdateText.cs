using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateText : MonoBehaviour
{

    public Transform player;
    public Tex scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z;
    }
}
