using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirDropScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {        
        if (collision.gameObject.name == "Player")
        {
            GameObject.Find("base").GetComponent<BaseScript>().RoundThis += 3.5f;
            SFXManager.sfxinstan.Audio.PlayOneShot(SFXManager.sfxinstan.pickincreatetime);
            Destroy(gameObject);    
        }
        
    }
}
