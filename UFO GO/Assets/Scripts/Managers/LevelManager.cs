using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float delay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", delay * 2);
        }
    }

    void Restart()
    {
        ScoreManager.health = 100;
        ScoreManager.score = 0;
        ScoreManager.ammo = 10;
        ScoreManager.fuel = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
