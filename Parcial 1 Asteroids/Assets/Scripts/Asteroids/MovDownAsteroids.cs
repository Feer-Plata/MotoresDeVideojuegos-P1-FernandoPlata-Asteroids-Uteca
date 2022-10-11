using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovDownAsteroids : MonoBehaviour
{
    //Atributos
    public int velAst;
    private void Update()
    {
        MovDonw();

    }
    void MovDonw()
    {
        transform.Translate(0,-velAst * Time.deltaTime, 0);
    }

}
