using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private GameOverText script;
    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("Game Manager").GetComponent<GameOverText>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -3)
        {
            DestroyPlayer();
        }
    }

    public void DestroyPlayer()
    {
        Destroy(gameObject);
        script.showGameOverText();
    }
}
