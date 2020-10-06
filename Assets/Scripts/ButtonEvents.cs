using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonEvents : MonoBehaviour
{
    public void button_play(){
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
    public void button_quit(){
        Application.Quit();
    }
}
