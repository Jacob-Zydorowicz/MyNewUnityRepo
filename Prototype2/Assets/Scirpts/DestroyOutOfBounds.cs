/*
 * Jacob Zydorowicz
 * Assignment 3 Prototype2
 * Destroys prefabs that go out of bounds
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 150;
    public float bottomBound = 0;
    HealthSystem healthSysScript;


    private void Start()
    {
        healthSysScript  = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < bottomBound)
        {
            //Debug.Log("Game Over!");
            healthSysScript.TakeDamage(); ;
            Destroy(gameObject);
        }
    }
}
