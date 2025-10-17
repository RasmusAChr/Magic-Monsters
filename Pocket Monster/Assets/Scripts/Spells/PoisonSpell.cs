using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonSpell : MonoBehaviour
{
    public float lifeDuration = 1f;
    public float lifeTimer;
    public static int BulletDamage = 40;

    void Start()
    {
        lifeTimer = lifeDuration;
    }

    void Update()
    {
        // Tjekker om skuddet skal oedelaegges.
        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0f)
        {
            Destroy(gameObject);
        }
    }

    // Hvis skuddet rammer noget, skal det ødelægges.
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
