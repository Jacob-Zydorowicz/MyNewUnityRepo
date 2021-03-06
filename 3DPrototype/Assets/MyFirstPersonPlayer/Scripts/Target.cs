/*
 * Jacob Zydorowicz
 * 3D prototype
 * controls target health and gun interaction
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;

    public void takeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            die();
        }
    }

    void die()
    {
        Destroy(gameObject);
    }
}
