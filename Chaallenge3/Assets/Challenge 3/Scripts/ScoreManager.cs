/*
 * Jacob Zydorowicz
 * Assignment 4 Challenge3
 * tracks score, determines game over, and updates UI text
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public bool gameOver = false;
    public bool won = true;
    public Text scoreText;
    public int score;
    PlayerControllerX pc;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;

        if(score >= 30)
        {
            gameOver = true;
        }

        if (gameOver && won)
        {
            scoreText.text = "You Won!" + "\n" + "Press R to restart!";
        }
        else if (gameOver && !won)
        {
            scoreText.text = "You Lose!" + "\n" + "Press R to restart!";
        }

        if(gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            score = 0;
        }
    }
}
