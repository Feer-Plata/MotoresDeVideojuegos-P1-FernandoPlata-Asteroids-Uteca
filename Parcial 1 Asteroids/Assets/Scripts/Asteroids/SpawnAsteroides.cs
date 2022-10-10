using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroides : MonoBehaviour
{
    //Atributos
    public bool puedeSpawnear = true;
    public List<GameObject> Asteroides;

    private void Update()
    {
        RespawnCora();
    }
    // Update is called once per frame

    private void RespawnCora()
    {
        if (puedeSpawnear)
        {
            StartCoroutine(Timing(1.5F));

        }
    }
    IEnumerator Timing(float time)
    {
        int randomIndex = Random.Range(0, Asteroides.Count);
        Instantiate(Asteroides[randomIndex]);
        puedeSpawnear = false;
        yield return new WaitForSeconds(time);
        puedeSpawnear = true;
    }

}
