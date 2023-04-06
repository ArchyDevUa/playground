using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOverText : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showGameOverText()
    {
        text.gameObject.SetActive(true);
        btn.gameObject.SetActive(true);
    }
}
