using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMan : MonoBehaviour
{

    bool gameHasEnded = false;
    public float delay = 1f;
    public GameObject levelWonUI;

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", delay * 3);
        }

    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void WinLevel()
    {
        levelWonUI.SetActive(true);
    }

}
