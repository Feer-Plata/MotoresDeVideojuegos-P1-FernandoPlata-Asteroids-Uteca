using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovLeft2Right : MonoBehaviour
{
    //Atributos
    public int velAst;
    private void Update()
    {
        MovDonw();

    }
    void MovDonw()
    {
        transform.Translate( -velAst * Time.deltaTime, 0, 0);
    }

}
