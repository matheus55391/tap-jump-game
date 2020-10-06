using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCano : MonoBehaviour
{

    [SerializeField]
    private GameObject cano;
    public float spawnTime = 5f;
    void Start()
    {
        startSpawns();
    }    
    private void startSpawns(){
        
        Instantiate(cano, transform.position, Quaternion.identity);
        StartCoroutine(WaitAndSpawn());
        
    }


    IEnumerator WaitAndSpawn(){
        
        yield return new WaitForSeconds(spawnTime);
        startSpawns();
        
    }
}
