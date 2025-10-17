using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Q1Gem : MonoBehaviour
{

    public int seeDistance;
    private bool PlayerCloseEnough;
    private bool FoundPlayer;
    private bool GameIsStarted;
    public Transform player;
    public GameObject GemUI;

    // Start is called before the first frame update
    void Start()
    {
    PlayerCloseEnough = true;
    FoundPlayer = false;
}

    // Update is called once per frame
    void Update()
    {
        // Find spiller
        if (FoundPlayer == false)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
            FoundPlayer = true;
            GameIsStarted = true;
        }

        if (GameIsStarted)
        {
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                // Hvis spilleren er tæt nok på, skal den vise et GUI som fortæller spilleren er færdig med questen.
                if (Vector2.Distance(transform.position, player.position) < seeDistance)
                {
                    if (PlayerCloseEnough == true)
                    {
                        GemUI.SetActive(true);
                        PlayerCloseEnough = false;
                    }
                }
                // Hvis spilleren ikke er tæt nok på, så vises GUI'en ikke.
                else
                {
                    if (PlayerCloseEnough == false)
                    {
                        GemUI.SetActive(false);
                        PlayerCloseEnough = true;
                    }
                }
            }
        }

    }

    // Funktion som sender spilleren tilbage til startområdet, og gør at questen ikke længere er aktiv.
    public void Quest1Done()
    {
        NPCQ1.q1 = false;
        SceneManager.LoadScene("MainGame");
    }
}
