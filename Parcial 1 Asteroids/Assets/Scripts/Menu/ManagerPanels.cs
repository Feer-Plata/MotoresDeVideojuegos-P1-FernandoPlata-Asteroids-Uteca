using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ManagerPanels : MonoBehaviour
{
    public GameObject PanelPrincipal;
    public GameObject PanelControles;
    //[SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;

    private bool juegoPausado = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (juegoPausado)
            {
                Reanudar();
            }
            else
            {
                Pausa();
            }
        }
    }
    public void Pausa()
    {
        juegoPausado = true;
        Time.timeScale = 0f;
        //botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }
    public void Reanudar()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        //botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }
    public void Reiniciar()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);

    }
    public void MenuControles()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);

    }

    public void Cerrar()
    {
        Application.Quit();
    }

    public void ActivatePanelPrincipal()
    {
        PanelPrincipal.SetActive(true);
    }
    public void DeactivatePanelPrincipal()
    {
        PanelPrincipal.SetActive(false);
    }
    public void ActivateControlPanel()
    {
        PanelControles.SetActive(true);
        DeactivateControlPanel();
    }
    public void DeactivateControlPanel()
    {
        PanelControles.SetActive(false);
        ActivateControlPanel();
    }
}
