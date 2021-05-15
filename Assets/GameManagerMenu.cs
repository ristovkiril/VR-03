using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerMenu : MonoBehaviour
{
    public Text learnMoreText;
    public Button start;
    public Button quit;

    // Start is called before the first frame update
    void Start()
    {
        learnMoreText.enabled = false;
    }


    public void PlayGame()
    {
        Debug.Log("Play game");
        SceneManager.LoadScene("SampleScene");   
    }

    public void LearnMore()
    {
        learnMoreText.enabled = !learnMoreText.enabled;
        start.gameObject.SetActive(!learnMoreText.enabled);
        quit.gameObject.SetActive(!learnMoreText.enabled);
    }

    public void Quit()
    {
        Application.Quit();
    }
}

