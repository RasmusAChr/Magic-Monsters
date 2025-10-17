using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForDeath : MonoBehaviour
{
    public GameObject player;
    public bool GameIsStarted;
    public GameObject GameOverMenuUI;
    public static bool GameOver;

    public void GameStart()
    {
        // Find spiller
        player = GameObject.FindGameObjectWithTag("Player");
        GameIsStarted = true;
        GameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameIsStarted)
        {
            // Hvis spilleren ikke er død, og ikke eksisterer i scenen, så skal der vises GameOver på en GUI.
            if (GameObject.FindGameObjectWithTag("Player") == null)
            {
                // Vis respawn menu
                GameOver = true;
                GameOverMenuUI.SetActive(true);
            }
            
        }
        
    }
}
