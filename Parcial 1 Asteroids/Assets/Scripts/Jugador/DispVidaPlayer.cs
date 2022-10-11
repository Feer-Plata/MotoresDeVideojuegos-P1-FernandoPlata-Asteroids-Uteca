using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DispVidaPlayer : MonoBehaviour
{

    //Atributos de jugador.
    //public int velocidadJugador;
    public int vidaJugador;
    int restHearts = 0;

    public UIVidaPlayer Corazones;

    //Atributos de disparo de jugador.
    public GameObject bala;
    public List<Transform> posicionesBala;
    void Update()
    {
        CheckLife();
        DisparoJugador();
        BajarvidaJugador();
        SubirScore();
    }

    public void CheckLife()
    {
        if (vidaJugador <= 0)
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
        }

    }

    public void BajarvidaJugador()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {

            vidaJugador--;
            restHearts += 1;
            Corazones.LifePlayer(restHearts);
        }

    }
    public void SubirScore()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            ScoreInit.score++;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        vidaJugador--;
        restHearts += 1;
        Corazones.LifePlayer(restHearts);
    }
}
