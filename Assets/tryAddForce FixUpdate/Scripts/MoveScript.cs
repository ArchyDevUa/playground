using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    private Rigidbody _rb;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // use GetKeyDown in Update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(0,300f,0);
        }
    }

    // use getKey in FixedUpdate
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _rb.AddForce(5f,0,0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _rb.AddForce(-5f,0,0);
        }
        
    }
}
