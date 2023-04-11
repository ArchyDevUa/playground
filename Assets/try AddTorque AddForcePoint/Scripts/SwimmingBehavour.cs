using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwimmingBehavour : MonoBehaviour
{
    [SerializeField] private float WaterDensity = 10f;
    private Rigidbody _rb;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float divePercent = -transform.position.y + transform.localScale.x * 0.5f;
        divePercent = Math.Clamp(divePercent, 0f, 1f);
        
        _rb.AddForce(Vector3.up * divePercent * WaterDensity);
        _rb.drag = divePercent * 2f;
        _rb.angularDrag = divePercent * 2f;


    }
}
