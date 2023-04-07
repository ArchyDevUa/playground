using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLogic : MonoBehaviour
{
    [SerializeField] private GameObject ammo;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            GameObject newBuulet =  Instantiate(ammo, transform.position, transform.rotation);
            newBuulet.GetComponent<Rigidbody>().velocity = transform.right * 5f;
        }
    }
}
