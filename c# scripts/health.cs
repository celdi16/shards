using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{

    public Slider slider;

    public void SetMaxHealth(int currenthealth)
    {
        slider.maxValue = currenthealth;
        slider.value = currenthealth;
    }

    public void Sethealth(int currenthealth)
    {
        slider.value = currenthealth;
    }

}
