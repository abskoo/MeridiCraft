using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthEnemy : MonoBehaviour
{
    public Slider slider;



    public void HealthUpdate(int vulue)
    {
        slider.value = vulue;

    }



}
