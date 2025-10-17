using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour    
{
    //Instatiate prefab
    public GameObject PlayerPrefab;
    public GameObject Monster1Prefab;
    public GameObject Monster2Prefab;
    public GameObject Monster3Prefab;
    public GameObject Monster4Prefab;
    public GameObject SpawnButton;
    public GameObject MainCamera;

    public bool GameIsStarted = false;

    private GameObject player;
    private GameObject MonsterIns;

    public Sprite player1;
    public Sprite player2;
    public Sprite player3;
    public Sprite player4;
    public Sprite player5;
    public Sprite player6;

    public Sprite monster1;
    public Sprite monster2;
    public Sprite monster3;
    public Sprite monster4;

    public void Start()
    {
        NPCQ1.q1 = false;
    }

    // Bliver kørt når der klikkes på Spawn knappen.
    public void SpawnPlayer()
    {
        // Laver en instans af spilleren.
        GameObject PlayerIns = Instantiate(PlayerPrefab, new Vector3(-2f, 3.9f, 0), Quaternion.identity);

        // Hvis brugeren har valgt spiller 1 i menuen
        if (MenuController.CurrentCharacterValue == "player1")
        {
            // Så skal den sætte PlayerSelected Animator Parameters til 1.
            PlayerIns.GetComponent<Animator>().SetInteger("PlayerSelected", 1);
        }
        else if(MenuController.CurrentCharacterValue == "player2")
        {
            PlayerIns.GetComponent<Animator>().SetInteger("PlayerSelected", 2);
        }
        else if(MenuController.CurrentCharacterValue == "player3")
        {
            PlayerIns.GetComponent<Animator>().SetInteger("PlayerSelected", 3);
        }
        else if(MenuController.CurrentCharacterValue == "player4")
        {
            PlayerIns.GetComponent<Animator>().SetInteger("PlayerSelected", 4);
        }
        else if(MenuController.CurrentCharacterValue == "player5")
        {
            PlayerIns.GetComponent<Animator>().SetInteger("PlayerSelected", 5);
        }
        else if(MenuController.CurrentCharacterValue == "player6")
        {
            PlayerIns.GetComponent<Animator>().SetInteger("PlayerSelected", 6);
        }
        
        // Hvis brugeren har valgt monster 1 i menuen.
        if(MenuController.CurrentMonsterValue == "monster1")
        {
            // Laver en instans af monster 1, og gør den til et child af spilleren.
            GameObject MonsterIns =  Instantiate(Monster1Prefab, new Vector3(-1f, 3.8f, 0), Quaternion.identity);
            MonsterIns.GetComponent<SpriteRenderer>().sprite = monster1;
            MonsterIns.transform.parent = PlayerIns.transform;
        }
        else if(MenuController.CurrentMonsterValue == "monster2")
        {
            GameObject MonsterIns = Instantiate(Monster2Prefab, new Vector3(-1f, 3.8f, 0), Quaternion.identity);
            MonsterIns.GetComponent<SpriteRenderer>().sprite = monster2;
            MonsterIns.transform.parent = PlayerIns.transform;
        }
        else if(MenuController.CurrentMonsterValue == "monster3")
        {
            GameObject MonsterIns = Instantiate(Monster3Prefab, new Vector3(-1f, 3.8f, 0), Quaternion.identity);
            MonsterIns.GetComponent<SpriteRenderer>().sprite = monster3;
            MonsterIns.transform.parent = PlayerIns.transform;
        }
        else if(MenuController.CurrentMonsterValue == "monster4")
        {
            GameObject MonsterIns = Instantiate(Monster4Prefab, new Vector3(-1f, 3.8f, 0), Quaternion.identity);
            MonsterIns.GetComponent<SpriteRenderer>().sprite = monster4;
            MonsterIns.transform.parent = PlayerIns.transform;
        }

        
        // Spawn knappen sættes herefter til usynlig.
        SpawnButton.SetActive(false);
        GameIsStarted = true;
    }
    

}
