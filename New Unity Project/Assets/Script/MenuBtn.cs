using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBtn : MonoBehaviour
{
    public CameraMain cameramain;
    public Menu menuscript;
    public PlayerController boolmenu;
    public GameObject canvasoption;
    public GameObject[] canvasmenu;

    public void resume()
    {
        GameObject.Find("Player").GetComponent<PlayerController>().speed = 0.1f;
        SFXManager.sfxinstan.Audio.PlayOneShot(SFXManager.sfxinstan.select);
        cameramain.enabled = true;
        menuscript.enabled = false;
        menuscript.onpause = false;
        boolmenu.menu = false;
        menuscript.GetComponent<Menu>().canvasmenu.SetActive(false);
    }
    public void restartbtn()
    {
        SceneManager.LoadScene("Game");
    }
    public void option()
    {
        SFXManager.sfxinstan.Audio.PlayOneShot(SFXManager.sfxinstan.select);
        canvasoption.SetActive(true);
        canvasmenu[0].SetActive(false);canvasmenu[1].SetActive(false);canvasmenu[2].SetActive(false);canvasmenu[3].SetActive(false);
        
    }
    public void Exit()
    {

        Application.Quit();
    }

}
