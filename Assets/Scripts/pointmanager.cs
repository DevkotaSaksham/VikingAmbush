using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointmanager : MonoBehaviour
{
    public static pointmanager instance;
    public Text points;
    public int score;
    void Start()
    {
        score = 0;
        points.text = score.ToString()+":Points";
    }


    void Awake()
    {
        instance = this;
    }
    public void scoreincrease()
    {
        score += 10;
        points.text = score.ToString() + ":Points";

    }
}
