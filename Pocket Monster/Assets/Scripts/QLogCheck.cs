using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QLogCheck : MonoBehaviour
{

    public GameObject noq;
    public GameObject q1;

   
    void Update()
    {
        // Hvis quest1 er aktiv
        if (NPCQ1.q1 == true)
        {
            // Så skal det vises i questloggen.
            noq.SetActive(false);
            q1.SetActive(true);
        }
    }
}
