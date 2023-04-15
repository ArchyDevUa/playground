using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private bool isActive = true;
    private void OnCollisionEnter(Collision collision)
    {
        if (!isActive) return;
        isActive = false;
        // Debug.Log(collision.gameObject.name);
        GetComponent<Rigidbody>().useGravity = true;
        // Rigidbody rb = transform.GetComponent<Rigidbody>();
        // rb.useGravity = true;
        // rb.velocity = new Vector3(0, 0, 0);

        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        Debug.Log(enemy);
        if (enemy)
        {
            enemy.Hit();
        }
    }
}
