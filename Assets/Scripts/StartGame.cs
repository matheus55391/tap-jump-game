using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    private bool fist;
    public GameObject startText;
    void Start()
    {
        startText.SetActive(true);
        fist = true;
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") || Input.GetMouseButtonDown(0)){
            if(fist == true){
                fist = false;
                Time.timeScale = 1;
                startText.SetActive(false);
            }            
        }


    }
    
}
