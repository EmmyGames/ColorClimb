using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenuUI;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            togglePause();
        }
    }
    public void togglePause()
    {
        pauseMenuUI.SetActive(!isPaused);
        Time.timeScale = Time.timeScale == 0.0f ? 1.0f : 0.0f;
        isPaused = !isPaused;
    }

    public void LoadMenu()
    {
        togglePause();
        SceneManager.LoadScene("Test Menu");
    }

    public void QuitGame()
    {
        togglePause();
        SceneManager.LoadScene("Start Menu"); 
    }
}
