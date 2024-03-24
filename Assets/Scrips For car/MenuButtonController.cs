using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonController : MonoBehaviour
{
    // Method to load the credits scene
    public void LoadCreditsScene()
    {
        SceneManager.LoadScene("EndCredit");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

