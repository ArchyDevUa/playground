using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessBoardGenerate : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private Material white;
    [SerializeField] private Material black;
    [SerializeField] private GameObject knight;
    void Start()
    {
        
        Instantiate(knight, new Vector3(0, 0.5f, 0), Quaternion.identity);
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
               GameObject renderedCude =  Instantiate(cube, new Vector3(i, 0, j), Quaternion.identity);
               if (i % 2 == 0 && j % 2 == 0 || i % 2 != 0 && j % 2 != 0)
               {
                   renderedCude.GetComponent<Renderer>().material = white;
               }
               else
               {
                   renderedCude.GetComponent<Renderer>().material = black;
               }
            }
        }

        
    }

    
}
