using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool menu = false;
    public BaseScript basescript;
    public float speed = 0.1f;
    public Menu menuscript;
    void Update()
    {
        
        float xdirection = Input.GetAxis("Horizontal");
        float zdirection = Input.GetAxis("Vertical");
        Vector3 movedirection = new Vector3(xdirection,0.0f,zdirection);
        transform.position += movedirection * speed;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            speed = 0f;
            menuscript.enabled = true;
            menuscript.onpause = true;
            menu = true;
        }
    }
}
