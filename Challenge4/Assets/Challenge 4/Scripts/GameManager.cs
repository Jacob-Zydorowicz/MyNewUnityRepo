/*
 * Jacob Zydorowicz
 * Assignment 7
 * manages win and loss conditons of game
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text waveText;
    public Text endText;
    private SpawnManagerX spawnManScript;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        spawnManScript = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManagerX>();
        gameOver = false;
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            endText.gameObject.SetActive(false);
            Time.timeScale = 1f;
        }

        waveText.text = "Wave: " + (spawnManScript.waveCount);

        if (spawnManScript.waveCount == 10)
        {
            gameOver = true;
        }

        if(spawnManScript.enemyInPlayerGoal == spawnManScript.waveCount && spawnManScript.waveCount!=0)
        {
            gameOver = true;
        }

        if (gameOver)
        {
            Time.timeScale = 0f;
            endText.gameObject.SetActive(true);

            if (spawnManScript.waveCount == 10)
            {
                endText.text = "You win! Press R to restart.";
            }
            else
            {
                endText.text = "You lose! Press R to restart.";
            }

            if (Input.GetKey(KeyCode.R))

            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

    }


}
