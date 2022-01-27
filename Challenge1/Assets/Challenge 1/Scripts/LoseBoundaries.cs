/*
 * Jacob Zydorowicz
 * Assignment 2 Challenge1
 * ends game if player goes out of bounds
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseBoundaries : MonoBehaviour
{
    public Text textbox;
    private void Update()
    {
        if (transform.position.y > 80|| transform.position.y <-45)
        {
            ScoreManager.gameOver = true;
        }

    }
}
