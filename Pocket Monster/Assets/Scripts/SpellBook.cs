using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellBook : MonoBehaviour
{

    public GameObject Spellbook;
    public static bool ShowingBook = false;

    // Update is called once per frame
    void Update()
    {
        //  Hvis man trykker på P og questlog ikke vises i forvejen.
        if (Input.GetKeyDown(KeyCode.P) && QuestLog.ShowingLog == false)
        {
            // Hvis man ikke kigger i spellbook.
            if (!ShowingBook)
            {
                // Aktiver book
                Spellbook.SetActive(true);
                ShowingBook = true;
            }
            else 
            {
                // Deaktiver book
                Spellbook.SetActive(false);
                ShowingBook = false;
            }
        }
    }
}
