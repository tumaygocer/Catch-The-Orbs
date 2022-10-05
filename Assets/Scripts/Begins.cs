using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begins : MonoBehaviour
{

    public GameObject mainLogo;
    public GameObject menuText;
    public GameObject splashBackround;
    public GameObject bgm;
    public GameObject gameControl;

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
    }
   
}
