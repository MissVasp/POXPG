using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public string newGameSceneName = "SampleScene";
    public void OnNewGame()
    {
        Debug.Log($"New Game Button clicked");
        SceneManager.LoadScene(newGameSceneName);
    }

    public void OnExit()
    {
        Debug.Log($"Exit button clicked");
        Application.Quit();
    }

}
