/*
 * Jacob Zydorowicz
 * Assignment 3 Challenge2
 * Destroys objects that go off screen
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    HealthSystem healthSys;
    private float leftLimit = -55;
    private float bottomLimit = -5;

    private void Start()
    {
        healthSys = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
            healthSys.TakeDamage();
        }

    }
}
