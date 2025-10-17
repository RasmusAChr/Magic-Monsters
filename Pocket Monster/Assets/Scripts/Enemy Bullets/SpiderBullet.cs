using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class SpiderBullet : MonoBehaviour
{
    private float speed = 10;

    private Transform player;
    private Vector2 target;

    public static int Losthealth = 0;

    void Start()
    {
        // Find spilleren og gør den til et target
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
    }

    void Update()
    {
        // Rykker projektilet
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // Hvis dens lifetimer løber ud, så skal projektilet fjernes.
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            
            DestroyProjectile();
            
        }
        
    }

    void OnTriggerEnter2D(Collider2D main)
    {
        // Hvis det rammer en spiller skal det ødelægge projektilet og sætte Losthealth til 1.
        if (main.CompareTag("Player"))
        {
            Destroy(gameObject);
            SpiderBullet.Losthealth = 1;
        }
        // Hvis det rammer en kant skal det ødelægge projektilet.
        else if (main.CompareTag("RockTree"))
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
