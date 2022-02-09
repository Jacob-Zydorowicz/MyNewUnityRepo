/*
 * Jacob Zydorowicz
 * Assignment 4 Challenge3
 * moves objects and background of the scene left when the game starts
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftX : MonoBehaviour
{
    public float speed;
    private ScoreManager scoreManagerScript;
    private float leftBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        scoreManagerScript = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // If game is not over, move to the left
        if (!scoreManagerScript.gameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }

        // If object goes off screen that is NOT the background, destroy it
        if (transform.position.x < leftBound && !gameObject.CompareTag("Background"))
        {
            Destroy(gameObject);
        }

    }
}
