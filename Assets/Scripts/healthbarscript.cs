using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbarscript : MonoBehaviour
{
    public static healthbarscript instance;

    public Slider slider;
    public void Awake()
    {
        instance = this;
    }
    public void decreseit(int health)
    {
        slider.value = health;
    }
    public void increaseit(int health)
    {
        slider.value = health;
    }
}
