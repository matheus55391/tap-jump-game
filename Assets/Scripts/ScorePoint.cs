using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePoint : MonoBehaviour
{
    //codigo responsavel por dectar quando o jogador
    //marca algum ponto

    private ScoreCanvas score;
    void Start()
    {
        score = GameObject.Find("Canvas").gameObject.GetComponent<ScoreCanvas>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            Debug.Log("Player");
            score.score_up();
        }
    }
}
