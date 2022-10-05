using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public GameObject timeDisplay;
    public int currentSeconds = 30;
    public bool countingDown = false;

    void Update()
    {
        if (countingDown == false)
        {
            countingDown = true;
            StartCoroutine(SubtractSecond());
        }
    }

    IEnumerator SubtractSecond()
    {
        yield return new WaitForSeconds(1);
        currentSeconds -= 1;
        timeDisplay.GetComponent<TextMeshProUGUI>().text = "Time " + currentSeconds;
        countingDown = false;
    }
}
