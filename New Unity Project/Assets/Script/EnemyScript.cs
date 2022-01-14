using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyScript : MonoBehaviour
{
    [SerializeField]GameObject effectenemyandenemy;
    private float nexthit;
    void Start()
    {
        Invoke("Destroy",6);
    }
    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Player":
                GameObject.Find("DeadZone").GetComponent<Dead>().dead = true;
                SFXManager.sfxinstan.Audio.PlayOneShot(SFXManager.sfxinstan.explosion);
                Destroy(effectenemyandenemy);
                break;
            case "Ground":
                GameObject.Find("base").GetComponent<BaseScript>().RoundThis -= 1;
                SFXManager.sfxinstan.Audio.PlayOneShot(SFXManager.sfxinstan.explosion);
                Destroy(effectenemyandenemy);
                break;
        }
    }
    void Destroy()
    {
        Destroy(this.gameObject);
    }
}
