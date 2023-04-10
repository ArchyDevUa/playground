using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
   private Rigidbody _rb;
   [SerializeField] private float Speed = 5f;

   private void Awake()
   {
      _rb = GetComponent<Rigidbody>();
   }

   private void FixedUpdate()
   {
      float sideForce = Input.GetAxis("Horizontal") * Speed;
      float forwardForce = Input.GetAxis("Vertical") * Speed;
      
      //двигаеться в глобальніх координатах
      //_rb.AddForce(sideForce,0,forwardForce);
      
      //двигаеться в локальных координатах
      _rb.AddRelativeForce(0,0,forwardForce);
      
      // крутить в локальніх координатах
      _rb.AddRelativeTorque(0,sideForce,0);
   }
}
