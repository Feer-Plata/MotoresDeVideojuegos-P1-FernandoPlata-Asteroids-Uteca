using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    //Atributos
    public int lifeAsteroid;
    public int speedRotAsteroid;

    // Update is called once per frame
    void Update()
    {
        CheckLife();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            lifeAsteroid--;
        }

        if (other.tag == "BalaJugador")
        {
            lifeAsteroid--;
        }
    }
    public void CheckLife()                                                     //Checa si el jugador tiene vida
    {
        if (lifeAsteroid <= 0)
        {
            Destroy(gameObject);                                               //Si no tiene vida, lo destruye.
        }
    }

    public void RotacionAsteoride()
    {
        transform.Translate(speedRotAsteroid * Time.deltaTime, 0, 0);
    }
}
