using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    Player player;
    private bool playerfound;
    public static float HP;

    public HealthBar healthBar;

    void Start()
    {
        HP = 25f;
        playerfound = false;
    }

    void Update() 
    {
        // Find spilleren.
        if (playerfound == false)
        {
            player = FindObjectOfType<Player>();
            playerfound = true;
        }
    }

    
    void OnTriggerEnter2D(Collider2D main)
    {
        // Hvis spilleren går ind i den.
        if (main.gameObject.tag == "Player")
        {
            // Hvis spillerens liv er mindre end det liv som den giver.
            if (player.currentHealth < player.maxHealth - HP)
            {
                player.currentHealth += HP;
            }

            // Hvis spillerens liv er mere eller lig det liv den giver.
            else if (player.currentHealth >= player.maxHealth - HP)
            {
                player.currentHealth = player.maxHealth;
            }

            // Herefter ødelæg det.
            Destroy(gameObject);
        }
    }
}
