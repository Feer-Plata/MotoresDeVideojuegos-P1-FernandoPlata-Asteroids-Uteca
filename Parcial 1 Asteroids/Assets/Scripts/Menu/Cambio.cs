using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cambio : MonoBehaviour
{
    public void Iniciar()
    {
        SceneManager.LoadScene(1);

    }

    public void Finalizar()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    public void Back2Menu()
    {
        SceneManager.LoadScene(0);
    }

}
