using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScript : MonoBehaviour
{
  
  
 
      public float sensitivity = 100.0f;
      public float speed = 10.0f;
  
      private float rotationX = 0.0f;
      private float rotationY = 0.0f;
  
      void Start()
      {
          Cursor.lockState = CursorLockMode.Locked;
          transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
      }
  
      void Update()
      {
          rotationX += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
          rotationY += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
          rotationY = Mathf.Clamp(rotationY, -90f, 90f);
  
          transform.localRotation = Quaternion.Euler(-rotationY, rotationX, 0.0f);
  
          float moveHorizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
          float moveVertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
  
          transform.position += transform.forward * moveVertical + transform.right * moveHorizontal;
  
          if (Input.GetKeyDown(KeyCode.Escape))
          {
              Cursor.lockState = CursorLockMode.None;
          }
      }
  
}
