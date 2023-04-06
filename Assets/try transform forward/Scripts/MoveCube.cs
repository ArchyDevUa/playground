using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + transform.forward * Time.deltaTime * Input.GetAxisRaw("Vertical");
        transform.position = transform.position + transform.right * Time.deltaTime * Input.GetAxisRaw("Horizontal");
        transform.position = transform.position + transform.up * Time.deltaTime * Input.GetAxisRaw("Jump");
    }
}
