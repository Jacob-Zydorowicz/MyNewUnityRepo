/*
 * Jacob Zydorowicz
 * Assignment 2 Prototype1
 * manages triggers for score
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")&&!triggered)
        {
            triggered = true;
            ScoreManager.score++;

        }
    }
}
