using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour
{
    public int seeDistance;
    private bool PlayerCloseEnough;
    private bool GameIsStarted;
    public Transform player;
    public GameObject SignUI;

    // Start is called before the first frame update
    void Start()
    {
        PlayerCloseEnough = true;
    }

    public void GameStart()
    {
        // Find spilleren
        player = GameObject.FindGameObjectWithTag("Player").transform;
        GameIsStarted = true;
    }

    // Update is called once per frame
    void Update()
    {

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
