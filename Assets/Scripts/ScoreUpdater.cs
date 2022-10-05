using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{

    public GameObject scoreDisplay;
    public GameObject orbDisplay;
    public static int orbScore;
    public static int orbCount;


    void Update()
    {
        scoreDisplay.GetComponent<TextMeshProUGUI>().text = "SCORE:" + orbScore;
        orbDisplay.GetComponent<TextMeshProUGUI>().text = "ORBS:" + orbCount;
    }

   
   
}
