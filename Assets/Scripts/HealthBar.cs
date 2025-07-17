using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider; //Gets slider

    public void SetMaxHealth(float health) //sets max health (duh)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(float health) //fuction that is called to use the slider to display the current
    {
        slider.value = health;
    }
}
