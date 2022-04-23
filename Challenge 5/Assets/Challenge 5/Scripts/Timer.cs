/*
 * Jacob Zydorowicz
 * Assignment 8
 * Timer for game in seconds
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Timer : MonoBehaviour
{

    //max and remaining time entered in seconds
    public int maxTime;
    public float timeRemaining;

    private float mins;
    private float secs;
    public GameManagerX gameMan;


    public TextMeshProUGUI timeText;
    void Start()
    {
        timeRemaining = maxTime;
        display();
    }


    //creates a minutes and seconds timer for game
    void FixedUpdate()
    {
        if (gameMan.isGameActive)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;

            }
            else
            {
                mins = 0;
                secs = 0;
                timeRemaining = 0;
                gameMan.GameOver();
            }
            display();

        }
    }

    //displays time in minutes and seconds
    public void display()
    {
        mins = Mathf.FloorToInt(timeRemaining / 60);
        secs = Mathf.FloorToInt(timeRemaining % 60);

        timeText.text = "Time: " + string.Format("{0:00}:{1:00}", mins, secs);
    }
}
