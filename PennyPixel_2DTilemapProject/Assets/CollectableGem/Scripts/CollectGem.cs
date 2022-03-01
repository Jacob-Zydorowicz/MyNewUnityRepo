/*
 * Jacob Zydorowicz
 * 2D prototype
 * increases and displays score
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectGem : MonoBehaviour
{

    public Text scoreText;
    public int score;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        score = 0;
        scoreText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameOver)
        {
            scoreText.text = "Score: " + score.ToString(string.Format("000", score));
        }
        
    }
}
