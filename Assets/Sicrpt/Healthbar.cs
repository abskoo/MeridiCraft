using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Healthbar : MonoBehaviour
{
   public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void setHealth(float value)
    {
        slider.value = value;
    }
}
