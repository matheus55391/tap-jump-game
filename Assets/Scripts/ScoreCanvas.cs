using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreCanvas : MonoBehaviour
{

    //codigo responsavel por atualizar o valor do score na tela
    [SerializeField]
    private Text my_score;
    private int score;
    void Start()
    {
        score = 0;
    }
    
    public void score_up(){

        score += 1;
        my_score.text = ""+score;
    }

    public int get_score(){
        return score;
    }
}
