using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using TMPro;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject fireBulletPrefab;
    public GameObject poisondartBulletPrefab;
    public GameObject electricBulletPrefab;
    public GameObject poisonBulletPrefab;


    public float autobulletForce = 20f;
    public float poisonbulletForce = 6f;

    public float cooldownFire = 1f;
    public float cooldownPoisonDart = 0.2f;
    public float cooldownElectric = 15f;
    public float cooldownPoison = 3f;
    private float Spell1autoNextFireTime = 0f;
    private float Spell2autoNextFireTime = 0f;
    private float Spell3autoNextFireTime = 0f;
    private float Spell4autoNextFireTime = 0f;

    public TMP_Text Spell1Countdown;
    public TMP_Text Spell2Countdown;
    public TMP_Text Spell3Countdown;
    public TMP_Text Spell4Countdown;

    void Start()
    {
        Spell1Countdown.text = Spell1autoNextFireTime.ToString("F1");
        Spell2Countdown.text = Spell2autoNextFireTime.ToString("F1");
        Spell3Countdown.text = Spell3autoNextFireTime.ToString("F1");
        Spell4Countdown.text = Spell4autoNextFireTime.ToString("F1");
    }

    void Update()
    {
        // Opdaterer cooldown på spells.
        // Hvis den næste fire time er større end den nuværende tid, så skal den opdaterer cooldown time.
        if (Spell1autoNextFireTime > Time.time)
        {
            Spell1Countdown.text = (Spell1autoNextFireTime - Time.time).ToString("F1");
        }
        if (Spell2autoNextFireTime > Time.time)
        {
            Spell2Countdown.text = (Spell2autoNextFireTime - Time.time).ToString("F1");
        }
        if (Spell3autoNextFireTime > Time.time)
        {
            Spell3Countdown.text = (Spell3autoNextFireTime - Time.time).ToString("F1");
        }
        if (Spell4autoNextFireTime > Time.time)
        {
            Spell4Countdown.text = (Spell4autoNextFireTime - Time.time).ToString("F1");
        }
        

        // Tjekker hvilket spell som der er aktivt.
        // Hvis spell 1 er aktivt.
        if (SpellManager.SelectedSpell == 1)
        {
            // Hvis brugeren skyder afsted og der ikke er cooldown på spell 1.
            if (Input.GetKey(KeyCode.Space) && Time.time > Spell1autoNextFireTime)
            {
                // Skyd et skud og giv spell 1 cooldown.
                Shoot();
                Spell1autoNextFireTime = Time.time + cooldownFire;
            }
        }
        else if (SpellManager.SelectedSpell == 2)
        {
            if (Input.GetKey(KeyCode.Space) && Time.time > Spell2autoNextFireTime)
            {
                Shoot();
                Spell2autoNextFireTime = Time.time + cooldownPoisonDart;
            }
            
        }
        else if (SpellManager.SelectedSpell == 3)
        {
            if (Input.GetKey(KeyCode.Space) && Time.time > Spell3autoNextFireTime)
            {
                Shoot();
                Spell3autoNextFireTime = Time.time + cooldownElectric;
            }
        }
        else if (SpellManager.SelectedSpell == 4)
        {
            if (Input.GetKey(KeyCode.Space) && Time.time > Spell4autoNextFireTime)
            {
                Shoot();
                Spell4autoNextFireTime = Time.time + cooldownPoison;
            }
        }

    }

    // Bliver kaldt, når der skal skydes et spell.
    void Shoot()
    {
        // Hvis det valgte spell er 1.
        if (SpellManager.SelectedSpell == 1)
        {
            // Lav en instans af skuddet og affyr det afsed med en valgt kraft. 
            GameObject bullet = Instantiate(fireBulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * autobulletForce, ForceMode2D.Impulse);
        }
        if (SpellManager.SelectedSpell == 2)
        {
            GameObject bullet = Instantiate(poisondartBulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * autobulletForce, ForceMode2D.Impulse);
        }
        if (SpellManager.SelectedSpell == 3)
        {
            GameObject bullet = Instantiate(electricBulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * autobulletForce, ForceMode2D.Impulse);
        }
        if (SpellManager.SelectedSpell == 4)
        {
            GameObject bullet = Instantiate(poisonBulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * poisonbulletForce, ForceMode2D.Impulse);
        }

    }
}
