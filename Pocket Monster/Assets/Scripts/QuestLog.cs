using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestLog : MonoBehaviour
{

    public GameObject Questlog;
    public static bool ShowingLog = false;

    // Update is called once per frame
    void Update()
    {
        //  Hvis man trykker på L og spellbook ikke vises i forvejen.
        if (Input.GetKeyDown(KeyCode.L) && SpellBook.ShowingBook == false)
        {
            // Hvis man ikke kigger i questloggen.
            if (!ShowingLog)
            {
                // Aktiver book
                Questlog.SetActive(true);
                ShowingLog = true;
            }
            else
            {
                // Deaktiver book
                Questlog.SetActive(false);
                ShowingLog = false;
            }
        }
    }
}