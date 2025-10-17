 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public TextMeshProUGUI usernamepreview;
    public TMP_InputField UsernameInput;
    public Image CurrentCharacter;
    public Image CurrentMonster;

    public static string CurrentCharacterValue;
    public static string CurrentMonsterValue;

    public static string UsernameIngame;

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

    [SerializeField] private GameObject StartButton;

    void Start()
    {
        // Vælger en start character og monster
        ChangeCharacterToPlayer1();
        ChangeMonsterToPlayer1();
    }

    void Update()
    {
        // Opdaterer brugernavnet i previewet.
        usernamepreview.text = UsernameInput.text;
    }

    public void ChangeUserNameInput()
    {
        // Hvis spillerens navn er 5 eller længere, så kan man se startknappen.
        if(UsernameInput.text.Length >= 5)
        {
            StartButton.SetActive(true);
        }
        // Hvis spillerens navn er 4 eller mindre, så kan man ikke se startknappen.
        else
        {
            StartButton.SetActive(false);
        }
    }

    // Når der bliver klikket på start knappen så indlæser den næste scene.
    public void StartGame()
    {
        UsernameIngame = UsernameInput.text;
        SceneManager.LoadScene(sceneBuildIndex:1);
    }

    // Ændre spillerens preview sprite til det valgte.
    public void ChangeCharacterToPlayer1()
    {
        CurrentCharacter.sprite = player1;
        CurrentCharacterValue = "player1";
    }
    public void ChangeCharacterToPlayer2()
    {
        CurrentCharacter.sprite = player2;
        CurrentCharacterValue = "player2";
    }
    public void ChangeCharacterToPlayer3()
    {
        CurrentCharacter.sprite = player3;
        CurrentCharacterValue = "player3";
    }
    public void ChangeCharacterToPlayer4()
    {
        CurrentCharacter.sprite = player4;
        CurrentCharacterValue = "player4";
    }
    public void ChangeCharacterToPlayer5()
    {
        CurrentCharacter.sprite = player5;
        CurrentCharacterValue = "player5";
    }
    public void ChangeCharacterToPlayer6()
    {
        CurrentCharacter.sprite = player6;
        CurrentCharacterValue = "player6";
    }
    
    // Ændre monsterets preview sprite til det valgte.
    public void ChangeMonsterToPlayer1()
    {
        CurrentMonster.sprite = monster1;
        CurrentMonsterValue = "monster1";
    }
    public void ChangeMonsterToPlayer2()
    {
        CurrentMonster.sprite = monster2;
        CurrentMonsterValue = "monster2";
    }
    public void ChangeMonsterToPlayer3()
    {
        CurrentMonster.sprite = monster3;
        CurrentMonsterValue = "monster3";
    }
    public void ChangeMonsterToPlayer4()
    {
        CurrentMonster.sprite = monster4;
        CurrentMonsterValue = "monster4";
    }
    
}
