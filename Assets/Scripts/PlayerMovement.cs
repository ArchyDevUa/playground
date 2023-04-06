using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _veticalMove;
    private float _horizontalMove;
    private Rigidbody _rb;
    public float speed = 10.0f;
    public GameObject rotationcenter;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _veticalMove = Input.GetAxis("Vertical");
        _horizontalMove = Input.GetAxis("Horizontal");
        
        _rb.AddForce(rotationcenter.transform.right * speed *  _horizontalMove);
        _rb.AddForce(rotationcenter.transform.forward * speed * _veticalMove);


    }
}
