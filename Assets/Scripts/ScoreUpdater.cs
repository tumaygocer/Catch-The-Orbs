using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{

    public GameObject scoreDisplay;
    void Start()
    {
        scoreDisplay.GetComponent<TextMeshProUGUI>().text = "Score: 100";
    }

   
    void Update()
    {
        
    }
}
