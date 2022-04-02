/*
 * Jacob Zydorowicz
 * Assignment 4 Challenge3
 * allows player to control balloon and interaction with game objects
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3 : MonoBehaviour
{
    

    public float skyBound = 14;
    public float groundBound = 1.4f;
    public float floatForce;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;

    public ScoreManager3 scoreMan;
    public Money monz;
    public Bomb bombs;
    

    private AudioSource playerAudio;
    public AudioClip bounceSound;


    // Start is called before the first frame update
    void Start()
    {
       
        playerRb = GetComponent<Rigidbody>();

        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();

        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }

    // Update is called once per frame
    public void Update()
    {
       
        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && !scoreMan.gameOver)
        {
            playerRb.AddForce(Vector3.up * floatForce);
        }
        else if (scoreMan.gameOver)
        {
            playerRb.constraints = RigidbodyConstraints.FreezeAll;
        }

        //keeps player in bounds and prevents build up of momentum
        if(transform.position.y > skyBound)
        {
            transform.position = new Vector3(transform.position.x, skyBound, transform.position.z);
            playerRb.velocity = new Vector3(0,0,0);
        }

     
        if (transform.position.y < groundBound)
        {
            transform.position = new Vector3(transform.position.x, groundBound, transform.position.z);
            playerRb.velocity = new Vector3(0, 15, 0);
            playerAudio.PlayOneShot(bounceSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            bombs.triggerEffect();
            scoreMan.gameOver = true;
            scoreMan.won = false;
            Destroy(other.gameObject);
           
        } 

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            scoreMan.score++;
            monz.triggerEffect();
            Destroy(other.gameObject);

        }

      

    }

}
