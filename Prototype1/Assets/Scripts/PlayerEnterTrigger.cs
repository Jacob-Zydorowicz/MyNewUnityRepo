﻿/*
 * Jacob Zydorowicz
 * Prototype1
 * increments score when player hits trigger
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerEnterTrigger : MonoBehaviour
{
  
 
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
}
