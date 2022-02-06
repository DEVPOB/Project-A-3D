using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeTosurvi : MonoBehaviour
{
    public TextMeshPro TimeText;
    public double timetosurvi;
    public double timetosurvibutround;
    public Menu menu;
    void Update()
    {
        
        if (GameObject.Find("DeadZone").GetComponent<Dead>().dead != true && menu.onpause == false)
        {
            timetosurvi += Time.deltaTime;
            timetosurvibutround = Math.Round(timetosurvi);
            TimeText.text = timetosurvibutround.ToString();
        }
    }
}
