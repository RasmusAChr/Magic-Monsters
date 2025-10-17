using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealth(float health)
    {
        // Sætter barens maks liv
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(float health)
    {
        // Justerer barens liv.
        slider.value = health;
    }
}
