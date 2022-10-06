using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBala : MonoBehaviour
{
    //Atributos
    public int speedShoot;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 15f);
    }

    // Update is called once per frame
    void Update()
    {

        this.transform.Translate(-speedShoot * Time.deltaTime, 0, 0, Space.World);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Asteroid")
        {
            Destroy(gameObject);
        }
    }
}
