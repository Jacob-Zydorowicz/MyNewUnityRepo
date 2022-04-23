/*
 * Jacob Zydorowicz
 * Assignment 8
 * Allows difficulty to be changed by buttons
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button difficultyBtn;

    public int difficulty;

    private GameManager gameMan;
    // Start is called before the first frame update
    void Start()
    {
        difficultyBtn = GetComponent<Button>();
        difficultyBtn.onClick.AddListener(setDifficulty);
        gameMan = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void setDifficulty()
    {
        Debug.Log(gameObject.name + " was clicked.");
        gameMan.startGame(difficulty);
    }
}
