using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;

    private Transform player;
    private Vector2 target;

    public static int Losthealth = 0;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            
            DestroyProjectile();
            
        }
        
    }

    void OnTriggerEnter2D(Collider2D main)
    {
        if (main.CompareTag("Player"))
        {
            DestroyProjectile();
            UnityEngine.Debug.Log("Test");
            Projectile.Losthealth = 1;
        }
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
