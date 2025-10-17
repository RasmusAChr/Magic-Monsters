using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellManager : MonoBehaviour
{
    public static int SelectedSpell;

    public GameObject Spell1RawImage;
    public GameObject Spell2RawImage;
    public GameObject Spell3RawImage;
    public GameObject Spell4RawImage;

    public Texture ActiveSpellImage;
    public Texture InactiveSpellImage;

    private RawImage img;

    // Start is called before the first frame update
    void Start()
    {
        // Starter ud med at have valgt et default spell
        SelectedSpell = 1;
        Spell1Active();
    }

    // Update is called once per frame
    void Update()
    {
        // Hvis man klikker på 1, så sættes spell 1 aktivt.
        if (Input.GetKey("1"))
        {
            SelectedSpell = 1;
            Spell1Active();
            Spell2Inactive();
            Spell3Inactive();
            Spell4Inactive();

        }
        // Hvis man klikker på 2, så sættes spell 2 aktivt.
        if (Input.GetKey("2"))
        {
            SelectedSpell = 2;

            Spell2Active();
            Spell1Inactive();
            Spell3Inactive();
            Spell4Inactive();
        }
        // Hvis man klikker på 3, så sættes spell 3 aktivt.
        else if (Input.GetKey("3"))
        {
            SelectedSpell = 3;

            Spell3Active();
            Spell1Inactive();
            Spell2Inactive();
            Spell4Inactive();
        }
        // Hvis man klikker på 4, så sættes spell 4 aktivt.
        else if (Input.GetKey("4"))
        {
            SelectedSpell = 4;

            Spell4Active();
            Spell1Inactive();
            Spell2Inactive();
            Spell3Inactive();
        }
    }

    // Spell 1 sættes aktivt ved at ændre på firkanten rundt omkring spell 1.
    void Spell1Active()
    {
        img = (RawImage)Spell1RawImage.GetComponent<RawImage>();
        img.texture = (Texture)ActiveSpellImage;
    }
    void Spell2Active()
    {
        img = (RawImage)Spell2RawImage.GetComponent<RawImage>();
        img.texture = (Texture)ActiveSpellImage;
    }
    void Spell3Active()
    {
        img = (RawImage)Spell3RawImage.GetComponent<RawImage>();
        img.texture = (Texture)ActiveSpellImage;
    }
    void Spell4Active()
    {
        img = (RawImage)Spell4RawImage.GetComponent<RawImage>();
        img.texture = (Texture)ActiveSpellImage;
    }

    // Spell 1 sættes inaktivt ved at ændre på firkanten rundt omkring spell 1.
    void Spell1Inactive()
    {
        img = (RawImage)Spell1RawImage.GetComponent<RawImage>();
        img.texture = (Texture)InactiveSpellImage;
    }
    void Spell2Inactive()
    {
        img = (RawImage)Spell2RawImage.GetComponent<RawImage>();
        img.texture = (Texture)InactiveSpellImage;
    }
    void Spell3Inactive()
    {
        img = (RawImage)Spell3RawImage.GetComponent<RawImage>();
        img.texture = (Texture)InactiveSpellImage;
    }
    void Spell4Inactive()
    {
        img = (RawImage)Spell4RawImage.GetComponent<RawImage>();
        img.texture = (Texture)InactiveSpellImage;
    }
}
