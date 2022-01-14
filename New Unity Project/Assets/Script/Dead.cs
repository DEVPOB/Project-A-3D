using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public bool dead;
    public Menu Deadstat;
    void Update()
    {
        if (dead == true)
        {
            GameObject.Find("Player").GetComponent<PlayerController>().speed = 0f;
            Deadstat.MenuCamera();
            Deadstat.Deadstat();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            dead = true;

        }
    }
}
