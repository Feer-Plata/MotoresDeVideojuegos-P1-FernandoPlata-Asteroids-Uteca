using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Atributos
    public int velocidad;

    void Update()
    {
        MovimientoJugador();
    }
    public void MovimientoJugador()
    {
        //Movimiento a hacia Arriba.
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, velocidad * Time.deltaTime, 0, Space.Self);
        }
        //Movimiento a la Izquierda.
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-velocidad * Time.deltaTime, 0, 0, Space.Self);
        }
        //Movimiento a la Derecha.
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(velocidad * Time.deltaTime, 0, 0, Space.Self);
        }
        //Movimiento a hacia Arriba.
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -velocidad * Time.deltaTime, 0, Space.Self);
        }
    }
}
