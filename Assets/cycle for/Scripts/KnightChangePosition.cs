using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightChangePosition : MonoBehaviour
{
    public void changePosition(Vector3 newPosition)
    {
        transform.position = new Vector3(newPosition.x, transform.position.y, newPosition.z);
    }
}
