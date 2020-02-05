
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameMan gameMan;
    public void OnTriggerEnter()
    {
        gameMan.WinLevel();
    }
}
