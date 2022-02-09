/*
 * Jacob Zydorowicz
 * Assignment 4 Prototype3
 * Moves the obstacles and background to the left creating the movement effect in game
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30f;
    public float leftBound = -15;
    PlayerController pCScript;

    private void Start()
    {
        pCScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if(pCScript.gameOver ==false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
       

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }

    
}
