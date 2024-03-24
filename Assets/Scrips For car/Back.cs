using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    // Method to load the credits scene
    public void GameScenes()
    {
        SceneManager.LoadScene("GameScenes");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
