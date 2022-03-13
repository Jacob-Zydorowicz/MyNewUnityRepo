/*
 * Jacob Zydorowicz
 * 3D prototype
 * triggers game over when trigger zone is reached
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerEnd : MonoBehaviour
{
    public Text winText;
 
    private void Start()
    {
        winText.enabled = false;
    }
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winText.enabled = true;
            winText.text = "You Win!";
        }
    }
}
