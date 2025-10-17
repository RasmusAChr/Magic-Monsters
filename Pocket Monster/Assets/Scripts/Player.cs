using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
	public AudioClip PlayerDamage1;
	public AudioClip PlayerDamage2;
	AudioSource audioPlayerDamage1;
	AudioSource audioPlayerDamage2;

	public float maxHealth = 100f;
	public float currentHealth;
	public GameObject player;

	public HealthBar healthBar;

	public TMP_Text usernameText;
	public TMP_Text HPText;

	public GameObject UserCanvas;

	// Start is called before the first frame update
	void Start()
	{
		audioPlayerDamage1 = AddAudio(false, false, 1f);
		audioPlayerDamage2 = AddAudio(false, false, 1f);

		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);

		usernameText.text = MenuController.UsernameIngame;
		HPText.text = currentHealth.ToString("F1") + "/100,0";

		PauseMenu.GameIsPaused = false;
		CheckForDeath.GameOver = false;
		CheckForDeathQ1.GameOver = false;
		UserCanvas.SetActive(true);

	}

	// Update is called once per frame
	void Update()
	{
		// Ændrer spillerens liv i gui'en.
		HPText.text = currentHealth.ToString("F1") + "/100,0";
		
		// Sætter spillerens liv i healthbaren til nuværende liv.
		healthBar.SetHealth(currentHealth);

		// Hvis en edderkop har ramt fjenden.
		if (SpiderBullet.Losthealth == 1)
		{
			// Tag skade fra edderkoppen.
			TakeDamage(Spider.bulletdamage);
			SpiderBullet.Losthealth = 0;
		}

		// Hvis en slange har ramt fjenden.
		if (SnakeBullet.Losthealth == 1)
		{
			// Tag skade fra slangen.
			TakeDamage(Snake.bulletdamage);
			SnakeBullet.Losthealth = 0;
		}

		// Hvis spilleren ikke har mere liv.
		if (currentHealth <= 0)
        {
			// Fjern spilleren.
			Destroy(player);
		}
		
		// Hvis der er GameOver
		if (CheckForDeath.GameOver == true)
		{
			// Sæt spillerens GUI til at være usynligt.
			UserCanvas.SetActive(false);
		}

		// Ellers hvis der ikke er GameOver.
		else if (CheckForDeath.GameOver == false)
		{
			// Hvis spillet i stedet er pauset.
			if (PauseMenu.GameIsPaused == true)
			{
				UserCanvas.SetActive(false);
			}
			// Hvis spillet heller ikke er pauset.
			else if (PauseMenu.GameIsPaused == false)
			{
				UserCanvas.SetActive(true);
			}
		}

		// Det samme GameOver princip som oven over, men bare i Quest 1.
		if (CheckForDeathQ1.GameOver == true)
		{
			UserCanvas.SetActive(false);
		}
		else if (CheckForDeathQ1.GameOver == false)
		{
			if (PauseMenu.GameIsPaused == true)
			{
				UserCanvas.SetActive(false);
			}
			else if (PauseMenu.GameIsPaused == false)
			{
				UserCanvas.SetActive(true);
			}
		}
	}

	// Funktion hvor spilleren tager skade.
	public void TakeDamage(float damage)
	{
		// Ændre spillerens nuværende liv.
		currentHealth -= damage;
		healthBar.SetHealth(currentHealth);

		// Vælg en tilfældig player damage lyd og afspil den.
		int SoundRandomizer = Random.Range(1, 100);
		if (SoundRandomizer <= 50)
		{
			audioPlayerDamage1.clip = PlayerDamage1;
			audioPlayerDamage1.Play();
		}
		else if (SoundRandomizer > 50)
		{
			audioPlayerDamage2.clip = PlayerDamage2;
			audioPlayerDamage2.Play();
		}
	}

	// Funktion til at sætte indstillinger på AudioSources.
	public AudioSource AddAudio(bool loop, bool playAwake, float vol)
	{
		AudioSource newAudio = gameObject.AddComponent<AudioSource>();
		newAudio.loop = loop;
		newAudio.playOnAwake = playAwake;
		newAudio.volume = vol;
		return newAudio;
	}
}
