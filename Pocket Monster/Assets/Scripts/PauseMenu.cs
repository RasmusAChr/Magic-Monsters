using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject playerprefab;

    void Update()
    {
        // Tjekker om brugeren trykker escape.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Hvis spillet allerede er pauset, så skal den fortsætte spillet.
            if (GameIsPaused)
            {
                Resume();
            }

            // Hvis spillet ikke er pauset, så skal den pause spillet.
            else {
                Pause();
            }
        }
    }

    // Sætter spillet igang igen
    public void Resume()
    {
        GameIsPaused = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        
    }

    // Pauser spillet
    void Pause()
    {
        GameIsPaused = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    // Skifter til main menu scenen.
    public void LoadMenu() 
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    // Går helt ud af spillet
    public void QuitGame()
    {
        Application.Quit();
    }
}
