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
    private Animator playerAnim;
    public ParticleSystem explosionPart;
    public ParticleSystem dirtPart;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        playerAnim = GetComponent<Animator>();

        playerAnim.SetFloat("Speed_f", 1.5f);

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
            dirtPart.Stop();
            playerAnim.SetTrigger("Jump_trig");
            audioSource.PlayOneShot(jumpSound, 1.0f);
            rb.AddForce(Vector3.up * jumpForce, jumpForceMode);
            isOnGround = false;
        }
    
        if(gameOver)
        {
            playerAnim.SetFloat("Speed_f", 0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") && !gameOver)
        {
            dirtPart.Play();
            isOnGround = true;
        }
        else if(collision.gameObject.CompareTag("Obstacle") && !gameOver)
        {
            explosionPart.Play();
            audioSource.PlayOneShot(crashSound, 1.0f);
            playerAnim.SetBool("Death_b",true);
            playerAnim.SetInteger("DeathType_int", 1);
            gameOver = true;

          
        }
    }
}
