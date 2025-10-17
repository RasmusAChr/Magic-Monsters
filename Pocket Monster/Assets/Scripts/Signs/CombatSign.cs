using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatSign : MonoBehaviour
{
    public int seeDistance;
    private bool PlayerCloseEnough;
    private bool FoundPlayer;
    private bool GameIsStarted;
    public Transform player;
    public GameObject SignUI;

    // Start is called before the first frame update
    void Start()
    {
        PlayerCloseEnough = true;
        FoundPlayer = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Find spilleren
        if (FoundPlayer == false)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
            FoundPlayer = true;
            GameIsStarted = true;
        }

        player = GameObject.FindGameObjectWithTag("Player").transform;

        if (GameIsStarted)
        {
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                // Når spilleren er tæt nok på, så skal skiltet vises.
                if (Vector2.Distance(transform.position, player.position) < seeDistance && PauseMenu.GameIsPaused == false)
                {
                    if (PlayerCloseEnough == true)
                    {
                        SignUI.SetActive(true);
                        PlayerCloseEnough = false;
                    }
                }
                // Når spilleren ikke er tæt nok på, så skal skiltet ikke vises.
                else
                {
                    if (PlayerCloseEnough == false)
                    {
                        SignUI.SetActive(false);
                        PlayerCloseEnough = true;
                    }
                }
            }
        }
    }
}
