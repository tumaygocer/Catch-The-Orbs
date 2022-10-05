using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbGenerate : MonoBehaviour
{
    public GameObject[] orbFall;
    public bool genOrb = false;
    public int orbLoc;
    public int orbCol;
    public float xPos;

    private void Start()
    {
        
    }
    void Update()
    {
        if (genOrb == false)
        {
            genOrb = true;            
            orbLoc = Random.Range(1, 4);
            orbCol = Random.Range(0, 3);
            StartCoroutine(OrbFalling());

            if (orbLoc == 1)
            {
                xPos = -1.75f;
            }

            if (orbLoc == 2)
            {
                xPos = 0;
            }

            if (orbLoc == 3)
            {
                xPos = 1.75f;
            }
        }
        
    }

    IEnumerator OrbFalling()
    {
        Instantiate(orbFall[orbCol], new Vector3(xPos, 8.5f, 0), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        genOrb = false;
    }
}
