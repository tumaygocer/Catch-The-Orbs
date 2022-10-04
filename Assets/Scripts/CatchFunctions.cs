using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchFunctions : MonoBehaviour
{
    public GameObject leftPlatform;
    public GameObject midPlatform;
    public GameObject rightPlatform;
    
    public void LeftPlat()
    {
        leftPlatform.SetActive(true);
        StartCoroutine(LeftReset());
    }

    public void MidPlat()
    {
        midPlatform.SetActive(true);
        StartCoroutine(MidReset());
    }

    public void RightPLat()
    {
        rightPlatform.SetActive(true);
        StartCoroutine(RightReset());
    }

    IEnumerator LeftReset()
    {
        yield return new WaitForSeconds(0.5f);
        leftPlatform.SetActive(false);
    }

    IEnumerator RightReset()
    {
        yield return new WaitForSeconds(0.5f);
        rightPlatform.SetActive(false);
    }

    IEnumerator MidReset()
    {
        yield return new WaitForSeconds(0.5f);
        midPlatform.SetActive(false);
    }

}
