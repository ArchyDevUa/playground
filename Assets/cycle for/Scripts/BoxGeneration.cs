using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxGeneration : MonoBehaviour
{
    [SerializeField] private GameObject cube;

    [SerializeField] private Material firstMaterial;
    [SerializeField] private Material secondMaterial;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {

                for (int k = 0; k < 10; k++)
                {
                    GameObject renderedCube = Instantiate(cube,  new Vector3(i,k,j), Quaternion.identity);
               
                    if (Random.Range(0, 2) == 0)
                    {
                        renderedCube.GetComponent<Renderer>().material = firstMaterial;
                    }
                    else
                    {
                        renderedCube.GetComponent<Renderer>().material = secondMaterial;
                    }
                }
                
              
            }
            
        }
        
    }

    
    
}
