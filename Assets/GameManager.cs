using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gamePaused = false;

    public void Pause()
    {
        if (gamePaused == false)
        {
            gamePaused = true;
            Debug.Log("Pause game");
            SceneManager.LoadScene("Menu");
        }
    }

}
