/*
 * Jacob Zydorowicz
 * 2D prototype
 * triggers game over when 10 gems and trigger zone is reached
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public CollectGem gemScript;
    private void Start()
    {
        gemScript = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<CollectGem>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")&&gemScript.score>=10)
        {
            print("win");
            gemScript.gameOver = true;
            gemScript.scoreText.text = "You Win!";
        }
    }
}
