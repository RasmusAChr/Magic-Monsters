using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForDeathQ1 : MonoBehaviour
{
    public GameObject player;
    public GameObject GameOverMenuUI;
    public bool playerFound;
    public static bool GameOver;

    public void Start()
    {
        playerFound = false;
        GameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Find spiller
        if (playerFound == false)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            playerFound = true;
        }

        // Hvis spilleren ikke er død, og ikke eksisterer i scenen, så skal der vises GameOver på en GUI.
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            // Vis respawn menu
            GameOver = true;
            GameOverMenuUI.SetActive(true);
        }
    }
}
