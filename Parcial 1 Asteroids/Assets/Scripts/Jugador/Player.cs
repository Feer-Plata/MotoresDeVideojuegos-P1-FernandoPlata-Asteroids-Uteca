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

    public Vector3 rotacionAsteroides;
    public float speedAsteorid;

    //Atributos de disparo de jugador.
    public GameObject bala;
    public List<Transform> posicionesBala;

    void Update()
    {
        LimitarMapa();
        MovimientoJugador();
        //RotacionNave();
        CheckLife();
        DisparoJugador();
        BajarvidaJugador();
        SubirScore();
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
    public void RotacionNave()
    {
        //Rotacion Horizontal
        if (Input.GetKeyDown(KeyCode.D))
        {
            rotacionAsteroides.z *= -1;
            transform.Rotate(0, 0, -90);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            rotacionAsteroides.z *= 1;
            transform.Rotate(0, 0, 90);
        }
        //Rotacion Vertical
        if (Input.GetKeyDown(KeyCode.W))
        {
            //rotacionAsteroides.z *= -1;
            transform.Rotate(0, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //rotacionAsteroides.z *= 1;
            transform.Rotate(0, 0, -180);
        }
        //transform.Rotate(rotacionAsteroides * speedAsteorid * Time.deltaTime);
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

    public void LimitarMapa()
    {
        //Teletransporte Horizontal
        if (this.transform.position.x < -9)
        {
            this.transform.position = new Vector3(9, transform.position.y, 0);
        }
        else if (this.transform.position.x >= 9)
        {
            this.transform.position = new Vector3(-9, transform.position.y, 0);
        }
        //Teletransporte Vertical
        if (this.transform.position.y < -5)
        {
            this.transform.position = new Vector3(transform.position.x, 5, 0);
        }
        else if (this.transform.position.y >= 5)
        {
            this.transform.position = new Vector3(transform.position.x, -5, 0);
        }
    }
    public void BajarvidaJugador()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            vidaJugador--;
        }

    }
    public void SubirScore()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            ScoreInit.score++;
            Debug.Log("Sumando al score: ");
        }
    }

}
