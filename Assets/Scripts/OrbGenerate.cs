using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbGenerate : MonoBehaviour
{
    public GameObject[] orbFall;
    public bool genOrb = false;
    public int orbLoc;
    public int orbCol;

    
    void Update()
    {
        if (genOrb == false)
        {
            genOrb = true;
            orbLoc = Random.Range(1, 4);
            orbCol = Random.Range(0, 3);
            StartCoroutine(OrbFalling());
        }
        
    }

    IEnumerator OrbFalling()
    {
        Instantiate(orbFall[orbCol], new Vector3(-1.75f, 8.5f, 0), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        genOrb = false;
    }
}
