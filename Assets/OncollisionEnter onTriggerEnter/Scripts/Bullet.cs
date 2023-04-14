using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = transform.GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.velocity = new Vector3(0, 0, 0);
    }
}
