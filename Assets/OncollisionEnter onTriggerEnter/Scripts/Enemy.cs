using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void Hit()
    {
        rb.AddForce(Vector3.up * 150f);
        rb.AddTorque(8000f,0f,0f);
    }
}
