using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioKillScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitAndKill());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator WaitAndKill(){
        yield return new WaitForSeconds(5f);
        Destroy(this.gameObject);
    }
}
