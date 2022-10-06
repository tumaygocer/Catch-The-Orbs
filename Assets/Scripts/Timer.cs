using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public GameObject timeDisplay;
    public int currentSeconds = 30;
    public bool countingDown = false;
    public bool isZero = false;
    public GameObject scorePanel;
    public GameObject bgm;
    public GameObject gameControlTimer;
    public GameObject finalScore;
    public GameObject finalOrbs;

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }  
    
    public void Quit()
    {
        Application.Quit();
    }
   
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

        if (isZero == true)
        {
            scorePanel.SetActive(true);
            bgm.SetActive(false);
            gameControlTimer.GetComponent<OrbGenerate>().enabled = false;
            finalScore.GetComponent<TextMeshProUGUI>().text = "SCORE: " + ScoreUpdater.orbScore;
            finalOrbs.GetComponent<TextMeshProUGUI>().text = "ORBS: " + ScoreUpdater.orbCount;
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
        timeDisplay.GetComponent<TextMeshProUGUI>().text = "Time: " + currentSeconds;
        countingDown = false;
    }
}
