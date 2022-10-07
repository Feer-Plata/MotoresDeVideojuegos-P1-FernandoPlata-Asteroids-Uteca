using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroides : MonoBehaviour
{
    //Atributos
    public bool PuedeSpawnear = true;
    public GameObject Aste1;
    public GameObject Aste2;
    public GameObject Aste3;


    private void Update()
    {
        if (PuedeSpawnear)
        {
            StartCoroutine(SpawnAsteroids(2f));
        }
        //CheckLife();
        Destroy(gameObject, 5f);
    }

    IEnumerator SpawnAsteroids(float time)
    {
        Instantiate(Aste1, new Vector3(-10.59f, -4.3f, 0), Quaternion.identity);
        PuedeSpawnear = false;
        yield return new WaitForSeconds(time);
        PuedeSpawnear = true;
    }

}
