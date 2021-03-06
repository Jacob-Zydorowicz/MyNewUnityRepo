/*
 * Jacob Zydorowicz
 * Assignement 7 Challenge 4
 * controls enemy ai
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject playerGoal;
    private int enemiesInPlayGoal;
    private SpawnManagerX spawnScript;

    // Start is called before the first frame update
    void Start()
    {
        playerGoal = GameObject.FindGameObjectWithTag("PlayerGoal");
        enemyRb = GetComponent<Rigidbody>();
        spawnScript = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManagerX>();
    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed * Time.deltaTime);
        

    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);
        } 
        else if (other.gameObject.name == "Player Goal")
        {
            Destroy(gameObject);
            spawnScript.enemyInPlayerGoal++;
            
        }

    }

}
