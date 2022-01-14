using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadMenu : MonoBehaviour
{
    public NewGameSystem restartgame;
    public GameObject CanvasMenu;
    public GameObject[] Canvasall;
    public void restartbtn()
    {
        restartgame.restart();
    }
    public void Mainmenu()
    {
        SFXManager.sfxinstan.Audio.PlayOneShot(SFXManager.sfxinstan.select);
        CanvasMenu.SetActive(true);
        Canvasall[0].SetActive(false);Canvasall[1].SetActive(false);Canvasall[2].SetActive(false);

        
    }
}
