using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreCanvas : MonoBehaviour
{

    //codigo responsavel por atualizar o valor do score na tela
    [SerializeField]
    private Text[] texts;
    private int score;
    private int recorde;
    void Start()
    {
        recorde = PlayerPrefs.GetInt("score_save");
        texts[2].text = ""+ PlayerPrefs.GetInt("score_save");
        score = 0;

    }
    
    public void score_up(){

        score += 1;
        texts[0].text = ""+score;
        texts[1].text = ""+score;
    
    }

    public void check_record(){
        if(score > recorde){
            recorde = score;
            PlayerPrefs.SetInt("score_save", recorde);
            texts[2].text = ""+ PlayerPrefs.GetInt("score_save");
        }
    }

    public int get_score(){
        return score;
    }
}
