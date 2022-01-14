using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Menu : MonoBehaviour
{
    // camera setup
    public Transform menucamera;
    public Vector3 camerasetoff;
    public float damp;
    private Vector3 velocity = Vector3.zero;
    
    // onmenu setup
    public bool onpause = false;

    public TextMeshPro statcurrent;
    public TextMeshPro survivaltext;
    public Dead DeadScript;
    public CameraMain cameramain;
    public TimeTosurvi timeTosurvi;
    public GameObject canvasded;
    public GameObject canvasmenu;
    
    void Update()
    {
        if (GameObject.Find("Player").GetComponent<PlayerController>().menu == true)
        {
            MenuCamera();
            menuUI();
        }
        
        
    }
    public void MenuCamera()
    {
        cameramain.enabled = false;
        Vector3 moveposition = menucamera.position + camerasetoff;
        Quaternion rotation = Quaternion.Euler(28,0,0);
        transform.position = Vector3.SmoothDamp(transform.position,moveposition,ref velocity,damp);
        transform.rotation = Quaternion.Slerp(transform.rotation,rotation,Time.deltaTime);
    }
    
    public void Deadstat()
    {
        canvasded.SetActive(true);
        statcurrent.text = "You're Dead";
        survivaltext.text = "survival time\n"+timeTosurvi.timetosurvibutround;
        
    }
    public void menuUI()
    {
        if (GameObject.Find("Player").GetComponent<PlayerController>().menu == true)
        {
            canvasmenu.SetActive(true);
        }
    }
}
