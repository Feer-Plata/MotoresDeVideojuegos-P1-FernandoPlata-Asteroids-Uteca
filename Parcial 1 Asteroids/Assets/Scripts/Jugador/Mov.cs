using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Mov : MonoBehaviour
{
    public float vertical;
    Rigidbody2D fisicas;
    public float horizontal;
    public float velJug = 10f;
    // Start is called before the first frame update
    void Start()
    {
        fisicas = GetComponent<Rigidbody2D>(); //Checa si tiene el rigidbody

    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        fisicas.velocity = new Vector2(horizontal * velJug, vertical * velJug); 
    }
}
