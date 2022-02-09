/*
 * Jacob Zydorowicz
 * Assignment 4 Prototype3
 * manages UI text to display score or game over messages
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public PlayerController pCScript;
    public bool won = false;
    
    void Start()
    {
        if(scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }

        if(pCScript == null)
        {
            pCScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        }

        scoreText.text = "Score: 0";
    }

    
    void Update()
    {
        if(!pCScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        if(pCScript.gameOver && !won)
        {
            scoreText.text = "You Lose!" + "\n" + "Press R to Try Again!";
        }

        if(score>= 10)
        {
            pCScript.gameOver = true;
            scoreText.text = "You Win!" + "\n" + "Press R to Try Again!";
        }

        if(pCScript.gameOver && Input.GetKey(KeyCode.R))

        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
