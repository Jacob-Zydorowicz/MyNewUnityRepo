/*
 * Jacob Zydorowicz
 * Assignment 3 Prototype2
 * Attached to food projectile and destroys both food and animal
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
