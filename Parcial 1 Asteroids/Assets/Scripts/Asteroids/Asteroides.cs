using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroides : MonoBehaviour
{
    //Atributos de asteroides
    public int lifeAst1 = 1;
    public int lifeAst2 = 3;
    public int lifeAst3 = 5;
    
    //Atributos
    public bool PuedeSpawnear = true;
    public GameObject Aste1;
    public GameObject Aste2;
    public GameObject Aste3;


    private void Update()
    {
        CheckLife();
        Destroy(gameObject, 3f);
    }

    public void CheckLife()                                                //Checa si el asteoride tiene vida
    {
        if (lifeAst1 <= 0)
        {
            ScoreInit.score++;                                            //Le suma uno al score.
            Destroy(Aste1);                                               //Si no tiene vida, lo destruye.
        }
        else if (lifeAst2 <= 0)
        {
            ScoreInit.score++;
            Destroy(Aste2);
        }
        else if (lifeAst3 <= 0)
        {
            ScoreInit.score++;
            Destroy(Aste3);
        }
    }
}
