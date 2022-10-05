using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public GameObject timeDisplay;
    public int currentSeconds = 30;
    public bool countingDown = false;
    public bool isZero = false;

    void Update()
    {
        if (isZero== false)
        {
            if (countingDown == false)
            {
                countingDown = true;
                StartCoroutine(SubtractSecond());
            }
        }
    }

    IEnumerator SubtractSecond()
    {
        yield return new WaitForSeconds(1);
        currentSeconds -= 1;
        if (currentSeconds == 0)
        {
            isZero = true;
        }
        timeDisplay.GetComponent<TextMeshProUGUI>().text = "Time " + currentSeconds;
        countingDown = false;
    }
}
