using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{
    // variable
    [SerializeField] Slider MusicVolumeSlider;
    [SerializeField] Slider SFXVolumeSlider;

    public AudioSource BGmusic;
    public AudioSource SFX;
    public GameObject CanvasOption;
    public GameObject[] canvasmenu;
    // function for use
    public void musicinput()
    {
        
        BGmusic.volume = MusicVolumeSlider.value;
        
    }
    public void sfxinput()
    {
        SFX.volume = SFXVolumeSlider.value;
    }
    public void back()
    {
        SFXManager.sfxinstan.Audio.PlayOneShot(SFXManager.sfxinstan.select);
        CanvasOption.SetActive(false);
        canvasmenu[0].SetActive(true);canvasmenu[1].SetActive(true);canvasmenu[2].SetActive(true);canvasmenu[3].SetActive(true);
    }
    public void SFXtest()
    {
        SFXManager.sfxinstan.Audio.PlayOneShot(SFXManager.sfxinstan.explosion);
    }
}
