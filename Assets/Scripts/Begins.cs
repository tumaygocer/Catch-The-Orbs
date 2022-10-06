using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Begins : MonoBehaviour
{

    public GameObject mainLogo;
    public GameObject menuText;
    public GameObject splashBackround;
    public GameObject bgm;
    public GameObject gameControl;
    public GameObject countdownText;
    public GameObject tapButton;

    void Start()
    {
        StartCoroutine(StartupGame());       
    }


    IEnumerator StartupGame()
    {
        yield return new WaitForSeconds(1);
        mainLogo.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        mainLogo.SetActive(false);
        menuText.SetActive(true);
        tapButton.SetActive(true);
    }

    public void TapToStart()
    {
        tapButton.SetActive(true);
        menuText.SetActive(false);
        splashBackround.GetComponent<Animator>().Play("SplashBackround");
        StartCoroutine(BeginTheGame());
    }

    IEnumerator BeginTheGame()
    {
        tapButton.SetActive(false);
        yield return new WaitForSeconds(1);        
        countdownText.SetActive(true);
        yield return new WaitForSeconds(1);
        countdownText.GetComponent<TextMeshProUGUI>().text = "2";
        yield return new WaitForSeconds(1);
        countdownText.GetComponent<TextMeshProUGUI>().text = "1";
        countdownText.SetActive(false);
        countdownText.GetComponent<TextMeshProUGUI>().text = "3";
        bgm.SetActive(true);
        splashBackround.SetActive(false);
        gameControl.GetComponent<Timer>().enabled = true;
        gameControl.GetComponent<OrbGenerate>().enabled = true;
    }
   
}
