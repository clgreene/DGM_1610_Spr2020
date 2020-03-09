using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{

    public Text fuelText;

    public Text scoreText;

    public Text healthText;
    

    // Update is called once per frame
    void Update()
    {
        fuelText.text = WASDMovement.fuel.ToString("0");
        scoreText.text = ScoreManager.score.ToString("0");
        healthText.text = ScoreManager.health.ToString("0");
    }
}
