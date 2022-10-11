using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBullet : MonoBehaviour
{
    //Atributos
    public float bulletSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * bulletSpeed * Time.deltaTime;
    }
}
