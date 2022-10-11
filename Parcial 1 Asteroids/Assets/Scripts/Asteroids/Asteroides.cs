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
        Destroy(gameObject, 15f);
    }

    public void CheckLife()                                                //Checa si el asteoride tiene vida
    {
        if (lifeAst1 <= 0)
        {
            ScoreInit.score++;                                            //Le suma uno al score.
            DestroyImmediate(Aste1, true);                                               //Si no tiene vida, lo destruye.
        }
        else if (lifeAst2 <= 0)
        {
            ScoreInit.score++;
            DestroyImmediate(Aste2, true);
        }
        else if (lifeAst3 <= 0)
        {
            ScoreInit.score++;
            DestroyImmediate(Aste3, true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BulletPlayer")
        {
            Destroy(gameObject);
            ScoreInit.score++;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
