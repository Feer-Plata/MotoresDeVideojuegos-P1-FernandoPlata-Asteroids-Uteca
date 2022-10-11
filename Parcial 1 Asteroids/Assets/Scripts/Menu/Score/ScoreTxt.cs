using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTxt : MonoBehaviour
{
    //Atributos
    public Text scoreTxt; 
    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "Score: " + ScoreInit.score;
    }
}
