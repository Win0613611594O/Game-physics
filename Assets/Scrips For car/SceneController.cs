using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private string previousScene;

    // Start is called before the first frame update
    void Start()
    {
        // Record the initial scene
        previousScene = SceneManager.GetActiveScene().name;
    }

    // Method to load a new scene and set it as the previous scene
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        previousScene = SceneManager.GetActiveScene().name;
    }

    // Method to go back to the previous scene
    public void GoBack()
    {
        SceneManager.LoadScene(previousScene);
    }

    // Method to quit the game
    public void QuitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        // Check for ESC key press
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GoBack();
        }
    }
}

