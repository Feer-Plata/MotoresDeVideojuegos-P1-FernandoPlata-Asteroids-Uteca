using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroides : MonoBehaviour
{
    //Atributos
    public Vector3 rotacionAsteroides;
    public float speedAsteorid;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            rotacionAsteroides.z *= -1;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            rotacionAsteroides.z *= 1;
        }
        transform.Rotate(rotacionAsteroides * speedAsteorid * Time.deltaTime);
    }
}
