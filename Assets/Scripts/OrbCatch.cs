using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbCatch : MonoBehaviour
{
    public AudioSource OrbCatchFx;

    void OnTriggerEnter(Collider other)
    {
        OrbCatchFx.Play();

        if (other.tag == "GreenOrb")
        {
            ScoreUpdater.orbScore = 1;
        }

        if (other.tag == "RedOrb")
        {
            ScoreUpdater.orbScore = 2;
        }

        if (other.tag == "BlueOrb")
        {
            ScoreUpdater.orbScore = 3;
        }
    }
}
