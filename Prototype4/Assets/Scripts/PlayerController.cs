/*
 * Jacob Zydorowicz
 * Assignment 7
 * Moves player with respect to camera rotation
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameManager gameScript;
    private float powerUpStrength = 15.0f;
    private Rigidbody playerRb;
    public float speed = 5.0f;
    private float forwardInput;
    private GameObject focalPoint;
    public GameObject powerUpIndicator;
    public bool hasPowerUp;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.FindGameObjectWithTag("FocalPoint");
        gameScript = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        powerUpIndicator.transform.position = transform.position + new Vector3(0, -.05f, 0);

        if(transform.position.y < -10)
        {
            gameScript.gameOver = true;
        }
    }

    private void FixedUpdate()
    {
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            Destroy(other.gameObject);

            StartCoroutine(powerUpCountDownRoutine());
        }

        powerUpIndicator.gameObject.SetActive(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(hasPowerUp && collision.gameObject.CompareTag("Enemy"))
        {
            print("player collide with enemy and powerup" );
            Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position).normalized;
            enemyRb.AddForce(awayFromPlayer * powerUpStrength, ForceMode.Impulse);
        }
    }

    IEnumerator powerUpCountDownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerUp = false;
        powerUpIndicator.gameObject.SetActive(false);
    }



}
