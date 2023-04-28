using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // basic player movement script using rigidbody velocity
    public float speed = 5f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // get input from player
        float x = -Input.GetAxis("Horizontal");
        float z = -Input.GetAxis("Vertical");
        // move player
        Vector3 move = new Vector3(x * speed, rb.velocity.y, z * speed);
        rb.velocity = move;
    }
}
