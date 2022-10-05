using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //Atributos de jugador.
    public int velocidadJugador;
    public int vidaJugador;
    public Slider barraVidaJugador;
    public Rigidbody2D curva;

    //Atributos de disparo de jugador.
    public GameObject bala;
    public List<Transform> posicionesBala;

    void Update()
    {
        MovimientoJugador();
        CheckLife();
        DisparoJugador();
        BajarvidaJugador();
    }
    public void MovimientoJugador()
    {
        //Movimiento a hacia Arriba.
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, velocidadJugador * Time.deltaTime, 0, Space.Self);
        }
        //Movimiento a la Izquierda.
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-velocidadJugador * Time.deltaTime, 0, 0, Space.Self);
        }
        //Movimiento a la Derecha.
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(velocidadJugador * Time.deltaTime, 0, 0, Space.Self);
        }
        //Movimiento a hacia Arriba.
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -velocidadJugador * Time.deltaTime, 0, Space.Self);
        }
    }

    public void CheckLife()
    {
        if (vidaJugador <=0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(3); //Abre escena 3 para voler a jugar o salir del juego.
        }
    }

    //Metodo para que el jugador pueda disparar.
    public void DisparoJugador()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {

            Instantiate(bala, posicionesBala[0].position, Quaternion.identity);
            Instantiate(bala, posicionesBala[1].position, Quaternion.identity);
        }

    }
    public void BajarvidaJugador()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            vidaJugador--;
        }

    }


}
