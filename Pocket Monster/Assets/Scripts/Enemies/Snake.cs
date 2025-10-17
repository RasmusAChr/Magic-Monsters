using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Snake : MonoBehaviour
{
    public static float bulletdamage = 0.5f;
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    public float seeDistance = 20;

    private float timeBetweenShots;
    public float startTimeBetweenShots;

    public GameObject projectile;
    public Transform player;
    public GameObject enemy;

    public GameObject gem;

    public int maxHealth = 350;
    public int currentHealth;

    private bool GameIsStarted;

    private float timeLeft = 0;

    public Transform firePoint;


    private bool PlayerFound;

    void Start()
    {
        // Sætter fjendens liv til det maksimale liv
        currentHealth = maxHealth;

        timeBetweenShots = startTimeBetweenShots;

        PlayerFound = false;

    }

    void Update()
    {

        // Leder efter spilleren indtil spilleren er fundet.
        if (PlayerFound != true)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
            GameIsStarted = true;
        }

        // Får variablen til at gå imod 0.
        if (timeLeft >= 0)
        {
            timeLeft -= Time.deltaTime;
        }

        if (GameIsStarted)
        {
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                if (timeLeft <= 0)
                {
                    // Hvis spilleren er indenfor den bestemte afstand
                    if (Vector2.Distance(transform.position, player.position) < seeDistance)
                    {
                        // Gaa efter spiller
                        if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
                        {
                            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
                            RotateTowards(player.position);

                        }

                        // Hvis spillerne kommer for tæt på, skal den tage afstand.
                        else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
                        {
                            transform.position = this.transform.position;

                        }

                        // Hvis spilleren kommer for tæt på, skal den rotere modo spilleren.
                        else if (Vector2.Distance(transform.position, player.position) < retreatDistance)
                        {
                            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
                            RotateTowards(player.position);
                        }

                        // Hvis der ikke er noget cooldown
                        if (timeBetweenShots <= 0)
                        {
                            // Affyr et projektil mod spilleren
                            Instantiate(projectile, firePoint.position, firePoint.rotation);
                            timeBetweenShots = startTimeBetweenShots;
                        }

                        // Hvis der er cooldown
                        else
                        {
                            // Får cooldown til at gå ned til 0.
                            timeBetweenShots -= Time.deltaTime;
                        }
                    }
                }
            }
        }

    }

    // Funktion som får fjende til at kigge imod taget (spilleren).
    private void RotateTowards(Vector2 target)
    {
        var offset = -90f;
        Vector2 direction = target - (Vector2)transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(Vector3.forward * (angle + offset));
    }

    // Funktion hvor fjenden tager skade.
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Hvis fjenden rammer en FireBullet
        if (collision.gameObject.name == "FireBullet(Clone)")
        {
            // Tag skade
            TakeDamage(FireSpell.BulletDamage);

            // Hvis fjendens liv er død.
            if (currentHealth <= 0)
            {
                // Sætter diamantens position til fjendens position og gør den synlig.
                gem.transform.position = new Vector2(enemy.transform.position.x, enemy.transform.position.y);
                gem.SetActive(true);
                Destroy(gameObject);
            }
        }

        // Hvis fjenden rammer en PoisonBullet
        else if (collision.gameObject.name == "PoisonBullet(Clone)")
        {
            TakeDamage(PoisonSpell.BulletDamage);

            // Hvis fjendens liv er død.
            if (currentHealth <= 0)
            {
                gem.transform.position = new Vector2(enemy.transform.position.x, enemy.transform.position.y);
                gem.SetActive(true);
                Destroy(gameObject);
            }
        }

        // Hvis fjenden rammer en ElectricBullet
        else if (collision.gameObject.name == "ElectricBullet(Clone)")
        {
            TakeDamage(ElectricSpell.BulletDamage);
            timeLeft = 5f;

            // Hvis fjendens liv er død.
            if (currentHealth <= 0)
            {
                gem.transform.position = new Vector2(enemy.transform.position.x, enemy.transform.position.y);
                gem.SetActive(true);
                Destroy(gameObject);
            }
        }

        // Hvis fjenden rammer en PoisonDartBullet
        else if (collision.gameObject.name == "PoisonDartBullet(Clone)")
        {
            TakeDamage(PoisonDartSpell.BulletDamage);

            // Hvis fjendens liv er død.
            if (currentHealth <= 0)
            {
                gem.transform.position = new Vector2(enemy.transform.position.x, enemy.transform.position.y);
                gem.SetActive(true);
                Destroy(gameObject);
            }
        }
    }

}
