using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BaseScript : MonoBehaviour
{
    public TextMeshPro BaseTimeout;
    public float RoundThis = 15;
    public double basetime;
    public Menu menu;
    void Update()
    {
        inzonetime();
    }
    void inzonetime()
    {
        if (menu.onpause == false)
        {
            RoundThis -= Time.deltaTime;
            basetime = Math.Round(RoundThis);
            BaseTimeout.text = basetime.ToString();
            if (basetime <= 0)
            {
                GameObject.Find("BaseWithTime").SetActive(false);
            }
        }
    }
}
