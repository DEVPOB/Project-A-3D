using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameSystem : MonoBehaviour
{
    
    public void restart()
    {
        GameObject.Find("Timescore").GetComponent<TimeTosurvi>().timetosurvi = 0;
        if (GameObject.Find("BaseWithTime").activeInHierarchy == false)
        {
            GameObject.Find("Base").SetActive(true);
        }
        GameObject.Find("BaseWithTime").GetComponent<BaseScript>().RoundThis = 15;
        GameObject.Find("Player").GetComponent<PlayerController>().speed = 0.1f;
    }
}

