using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCQ1 : MonoBehaviour
{
    public static bool q1 = false;

    public AudioClip Farmer1;
    public AudioClip Farmer2;
    public AudioClip Farmer3;
    public AudioClip Farmer4;
    AudioSource audioData1;
    AudioSource audioData2;
    AudioSource audioData3;
    AudioSource audioData4;

    private int seeDistance = 5;
    public Transform player;
    private bool GameIsStarted;
    public GameObject Q1Wrapper;

    public bool PlayerCloseEnough;

    void Start()
    {
        PlayerCloseEnough = true;

        audioData1 = AddAudio(false, false, 1f);
        audioData2 = AddAudio(false, false, 1f);
        audioData3 = AddAudio(false, false, 1f);
        audioData4 = AddAudio(false, false, 1f);
    }

    public void GameStart()
    {
        // Finder spiller
        player = GameObject.FindGameObjectWithTag("Player").transform;
        GameIsStarted = true;
    }

    void Update()
    {
        if (GameIsStarted)
        {
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                // Hvis spilleren er tæt nok på så viser den quest gui.
                if (Vector2.Distance(transform.position, player.position) < seeDistance)
                {
                    if (PlayerCloseEnough == true)
                    {
                        Q1Wrapper.SetActive(true);
                        //audioData = GetComponent<AudioSource>();
                        //audioData.Play(0);
                        int SoundRandomizer = Random.Range(1, 100);
                        if (SoundRandomizer <= 30)
                        {
                            PlayFarmer1();
                        }
                        else if (SoundRandomizer > 30 && SoundRandomizer <=60)
                        {
                            PlayFarmer2();
                        }
                        else if (SoundRandomizer > 60 && SoundRandomizer <= 90)
                        {
                            PlayFarmer3();
                        }
                        else if (SoundRandomizer > 90)
                        {
                            PlayFarmer4();
                        }
                        PlayerCloseEnough = false;
                    }
                }
                // Hvis spilleren ikke er tæt nok på så viser den ikke quest gui.
                else
                {
                    if (PlayerCloseEnough == false)
                    {
                        Q1Wrapper.SetActive(false);
                        PlayerCloseEnough = true;
                    }
                    
                }
            }
        }        
    }

    // Når man klikker på start quest
    public void GotoQ1()
    {
        // Indlæser quest 1 bane.
        SceneManager.LoadScene("Quest1");
    }

    // Funktion til at tilføje indstillinger til AudioSource.
    public AudioSource AddAudio(bool loop, bool playAwake, float vol)
    {
        AudioSource newAudio = gameObject.AddComponent<AudioSource>();
        newAudio.loop = loop;
        newAudio.playOnAwake = playAwake;
        newAudio.volume = vol;
        return newAudio;
    }

    // Spil farmer lyd.
    public void PlayFarmer1()
    {
        audioData1.clip = Farmer1;
        audioData1.Play();
    }
    public void PlayFarmer2()
    {
        audioData2.clip = Farmer2;
        audioData2.Play();
    }
    public void PlayFarmer3()
    {
        audioData3.clip = Farmer3;
        audioData3.Play();
    }
    public void PlayFarmer4()
    {
        audioData4.clip = Farmer4;
        audioData4.Play();
    }

    // Sætter questen til at være aktiv.
    public void SetQ1Active()
    {
        q1 = true;
    }

}
