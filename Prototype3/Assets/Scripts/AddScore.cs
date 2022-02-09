/*
 * Jacob Zydorowicz
 * Assignment 4 Prototype3
 * increases score when player jumps over obstacle
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    private UIManager uIManager;
    private bool triggered = false;
    void Start()
    {
        uIManager = GameObject.FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            uIManager.score++;
        }
    }
}
