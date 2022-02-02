/*
 * Jacob Zydorowicz
 * Assignment 3 Prototype2
 * Controls player movement
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    private float xRange = 18;

    // Update is called once per frame
    void Update()
    {
        //horizontal input
        horizontalInput = Input.GetAxis("Horizontal");

        //move with input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //prevents player from leaving bounds
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
