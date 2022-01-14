using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateanddestroy : MonoBehaviour
{    
    public BaseScript basescript;
    public GameObject increatetime;
    public GameObject EnemyDecreateTime;
    private float nextspawn;  
    public Menu menu; 


    void Update()
    {
        if (Time.time > nextspawn && menu.onpause == false)
        {
            Spawnairdrop();
            enemyspawn();
            nextspawn= Time.time + 3;
        }
        
    }
    void Spawnairdrop()
    {
        GameObject[] totalairdrop = GameObject.FindGameObjectsWithTag("AirDrop");
        if (totalairdrop.Length == 0)
        {
            float spawnpositionx = Random.Range(17.35f,7.23f);

            float spawnpositionz = Random.Range(13.57f,4.54f);

            Vector3 spawnposition = new Vector3(spawnpositionx,9.59f,spawnpositionz);
            Instantiate(increatetime,spawnposition,Quaternion.identity);
        }
    }   
    void enemyspawn()
    {
        float spawnpositionx = Random.Range(17.35f,7.23f);

        float spawnpositionz = Random.Range(13.57f,4.54f);

        Vector3 spawnpositionenemy = new Vector3(spawnpositionx,9.59f,spawnpositionz);
        Instantiate(EnemyDecreateTime,spawnpositionenemy,Quaternion.identity);
    }
    
}
