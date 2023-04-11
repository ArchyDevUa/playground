using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreate : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float bulletVelocity = 20f;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) )
        {
          GameObject newBullet =   Instantiate(bullet, transform.position, transform.rotation);
          newBullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletVelocity;
        }
    }
}
