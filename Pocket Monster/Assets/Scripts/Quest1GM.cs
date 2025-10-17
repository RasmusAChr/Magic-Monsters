using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest1GM : MonoBehaviour
{
    //Instatiate prefab
    public GameObject PlayerPrefab;
    public GameObject Monster1Prefab;
    public GameObject Monster2Prefab;
    public GameObject Monster3Prefab;
    public GameObject Monster4Prefab;

    private GameObject player;
    private GameObject MonsterIns;

    public Sprite player1;
    public Sprite player2;
    public Sprite player3;
    public Sprite player4;
    public Sprite player5;
    public Sprite player6;

    // Næsten det samme script som det originale GameManager script.
    public void Start()
    {
        GameObject PlayerIns = Instantiate(PlayerPrefab, new Vector3(0, 0, 0), Quaternion.identity);


        if (MenuController.CurrentCharacterValue == "player1")
        {
            PlayerIns.GetComponent<Animator>().SetInteger("PlayerSelected", 1);
        }
        else if (MenuController.CurrentCharacterValue == "player2")
        {
            PlayerIns.GetComponent<Animator>().SetInteger("PlayerSelected", 2);
        }
        else if (MenuController.CurrentCharacterValue == "player3")
        {
            PlayerIns.GetComponent<Animator>().SetInteger("PlayerSelected", 3);
        }
        else if (MenuController.CurrentCharacterValue == "player4")
        {
            PlayerIns.GetComponent<Animator>().SetInteger("PlayerSelected", 4);
        }
        else if (MenuController.CurrentCharacterValue == "player5")
        {
            PlayerIns.GetComponent<Animator>().SetInteger("PlayerSelected", 5);
        }
        else if (MenuController.CurrentCharacterValue == "player6")
        {
            PlayerIns.GetComponent<Animator>().SetInteger("PlayerSelected", 6);
        }

        if (MenuController.CurrentMonsterValue == "monster1")
        {
            GameObject MonsterIns =  Instantiate(Monster1Prefab, new Vector3(1f, -0.1f, 0), Quaternion.identity);
            MonsterIns.transform.parent = PlayerIns.transform;
        }
        else if(MenuController.CurrentMonsterValue == "monster2")
        {
            GameObject MonsterIns = Instantiate(Monster2Prefab, new Vector3(1f, -0.1f, 0), Quaternion.identity);
            MonsterIns.transform.parent = PlayerIns.transform;
        }
        else if(MenuController.CurrentMonsterValue == "monster3")
        {
            GameObject MonsterIns = Instantiate(Monster3Prefab, new Vector3(1f, -0.1f, 0), Quaternion.identity);
            MonsterIns.transform.parent = PlayerIns.transform;
        }
        else if(MenuController.CurrentMonsterValue == "monster4")
        {
            GameObject MonsterIns = Instantiate(Monster4Prefab, new Vector3(1f, -0.1f, 0), Quaternion.identity);
            MonsterIns.transform.parent = PlayerIns.transform;
        }

    }
}
