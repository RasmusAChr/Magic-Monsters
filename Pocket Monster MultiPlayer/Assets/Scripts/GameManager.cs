using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GameManager : MonoBehaviourPun
{
    /*
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

    public bool SearchForPlayer = true;
    */
    public void Update()
    {/*
        if (SearchForPlayer)
        {
            if (GameObject.FindWithTag("Player"))
            {
                SearchForPlayer = false;
                SpawnPlayer();
            }
        }*/
       
    }
    //[PunRPC]
    void SpawnPlayer()
    {/*
        //GameObject PlayerIns = Instantiate(PlayerPrefab, new Vector3(0, 0, 0), Quaternion.identity);

        player = GameObject.FindWithTag("Player");

        if (MenuController.CurrentCharacterValue == "player1")
        {
            player.GetComponent<SpriteRenderer>().sprite = player1;
        }
        else if(MenuController.CurrentCharacterValue == "player2")
        {
            player.GetComponent<SpriteRenderer>().sprite = player2;
        }
        else if(MenuController.CurrentCharacterValue == "player3")
        {
            player.GetComponent<SpriteRenderer>().sprite = player3;
        }
        else if(MenuController.CurrentCharacterValue == "player4")
        {
            player.GetComponent<SpriteRenderer>().sprite = player4;
        }
        else if(MenuController.CurrentCharacterValue == "player5")
        {
            player.GetComponent<SpriteRenderer>().sprite = player5;
        }
        else if(MenuController.CurrentCharacterValue == "player6")
        {
            player.GetComponent<SpriteRenderer>().sprite = player6;
        }
        
        if(MenuController.CurrentMonsterValue == "monster1")
        {
            GameObject MonsterIns =  Instantiate(Monster1Prefab, new Vector3(1f, -0.1f, 0), Quaternion.identity);
            MonsterIns.GetComponent<SpriteRenderer>().sprite = monster1;
            MonsterIns.transform.parent = player.transform;
        }
        else if(MenuController.CurrentMonsterValue == "monster2")
        {
            GameObject MonsterIns = Instantiate(Monster2Prefab, new Vector3(1f, -0.1f, 0), Quaternion.identity);
            MonsterIns.GetComponent<SpriteRenderer>().sprite = monster2;
            MonsterIns.transform.parent = player.transform;
        }
        else if(MenuController.CurrentMonsterValue == "monster3")
        {
            GameObject MonsterIns = Instantiate(Monster3Prefab, new Vector3(1f, -0.1f, 0), Quaternion.identity);
            MonsterIns.GetComponent<SpriteRenderer>().sprite = monster3;
            MonsterIns.transform.parent = player.transform;
        }
        else if(MenuController.CurrentMonsterValue == "monster4")
        {
            GameObject MonsterIns = Instantiate(Monster4Prefab, new Vector3(1f, -0.1f, 0), Quaternion.identity);
            MonsterIns.GetComponent<SpriteRenderer>().sprite = monster4;
            MonsterIns.transform.parent = player.transform;
        }*/

        

        //SpawnButton.SetActive(false);
        //MainCamera.SetActive(false);
        //GameIsStarted = true;
    }
    

}
