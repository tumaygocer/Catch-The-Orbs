using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{

    public GameObject scoreDisplay;
    public static int orbScore;


    void Update()
    {
        scoreDisplay.GetComponent<TextMeshProUGUI>().text = ""+ orbScore;
    }

   
   
}
