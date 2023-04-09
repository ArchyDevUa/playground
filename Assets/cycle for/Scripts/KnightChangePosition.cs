using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightChangePosition : MonoBehaviour
{
    public void changePosition(Vector3 newPosition)
    {
        transform.position = new Vector3(newPosition.x, 0.5f, newPosition.z);
    }
}
