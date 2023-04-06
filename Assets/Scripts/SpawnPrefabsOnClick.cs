using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefabsOnClick : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Material _firstMaterial;
    [SerializeField] private Material _secondMaterial;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
          GameObject newPrefab =   Instantiate(_prefab,transform.position,transform.rotation,gameObject.transform);
          newPrefab.transform.localScale = (Vector3.one * Random.Range(0.5f, 1f));
          if (Random.Range(0, 2) == 1)
          {
              newPrefab.GetComponent<Renderer>().material = _firstMaterial;
          }
          else
          {
              newPrefab.GetComponent<Renderer>().material = _secondMaterial;
          }
        }
    }
}
