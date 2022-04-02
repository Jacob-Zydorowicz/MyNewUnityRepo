/*
 * Jacob Zydorowicz
 * Assignment 6
 * Bomb class inheriting from Collectable base class that triggers the bomb effects
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class Bomb : Colletable
{
    public override void triggerEffect()
    {

        source = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();
        particles.Play();
        source.PlayOneShot(clip, 1.0f);
    }

}
