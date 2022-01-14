using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip pickincreatetime;
    public AudioClip explosion;
    public AudioClip select;
    public static SFXManager sfxinstan;

    void Awake()
    {
        if (sfxinstan != null && sfxinstan != this)
        {
            Destroy(this.gameObject);
            return;
        }
        sfxinstan = this;
        DontDestroyOnLoad(this);
    }
    
}
