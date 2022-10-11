using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    private Rigidbody2D rb;
    public float acceleration;
    public float maxSpeed;
    public float inertia;
    public float angularSpeed;

    private float vertical;
    private float horizontal;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.drag = inertia;
    }

    private void Update()
    {
        vertical = InputMovPlayer.vertical;
        horizontal = InputMovPlayer.horizontal;
        Rotate();
    }


    private void Rotate()
    {
        if (horizontal == 0)
        {
            return;
        }
        transform.Rotate(0, 0, -angularSpeed * horizontal * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        var forwardMotor = Mathf.Clamp(vertical, 0f, 1f);
        rb.AddForce(transform.up * acceleration * forwardMotor);
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }

    public void Lose()
    {
        rb.velocity = Vector3.zero;
        transform.position = Vector3.zero;
    }


}
