/*
 * Jacob Zydorowicz
 * Assignment 4 Prototype3
 * Controls the jumping of the player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce;
    public ForceMode jumpForceMode;
    public float gravModifier;
    public bool isOnGround = true;
    public bool gameOver = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if(Physics.gravity.y > -10)
        {
            Physics.gravity *= gravModifier;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            Debug.Log("Jump");
            rb.AddForce(Vector3.up * jumpForce, jumpForceMode);
            isOnGround = false;
        }
    
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") && !gameOver)
        {
            isOnGround = true;
        }
        else if(collision.gameObject.CompareTag("Obstacle") && !gameOver)
        {
            gameOver = true;
        }
    }
}
