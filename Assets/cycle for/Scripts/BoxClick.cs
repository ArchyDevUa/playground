using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxClick : MonoBehaviour
{

    private void OnMouseDown()
    { 
        KnightChangePosition   script = GameObject.FindGameObjectWithTag("Knight").GetComponent<KnightChangePosition>();
        script.changePosition(new Vector3(transform.position.x,0.5f,transform.position.z));
        
    }
}
