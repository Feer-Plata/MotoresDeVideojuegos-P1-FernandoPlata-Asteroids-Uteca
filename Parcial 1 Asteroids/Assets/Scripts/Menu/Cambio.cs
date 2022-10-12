using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cambio : MonoBehaviour
{
    public void Iniciar()
    {
        //Escena juego
        SceneManager.LoadScene(1);
        ScoreInit.score = 0;

    }

    public void Finalizar()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    public void Back2Menu()
    {
        //Escena menu principal
        SceneManager.LoadScene(0);
    }

}
