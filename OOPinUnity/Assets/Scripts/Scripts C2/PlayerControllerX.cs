/*
 * Jacob Zydorowicz
 * Assignment 3 Challenge2
 * Spawns dogs when space is pressed without spam while game is active
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float coolDown = 1f;
    private float nextDogTime;
    public HealthSystem healtSys;

    

    private void Update()
    {
        //spawns dogs when space is pressed with a second cooldown
        
        if (Input.GetKeyDown(KeyCode.Space)&&Time.time>nextDogTime&&!healtSys.gameOver)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            nextDogTime = Time.time + coolDown;
        } 
        
        
    }
}
