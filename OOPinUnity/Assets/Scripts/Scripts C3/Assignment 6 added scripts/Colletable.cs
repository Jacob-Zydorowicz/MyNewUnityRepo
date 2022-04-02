/*
 * Jacob Zydorowicz
 * Assignment 6
 * Collectable base class from which money and bomb are derived from
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Colletable : MonoBehaviour, IEffectTrigger
{
    public ParticleSystem particles;
    public AudioSource source;
    public AudioClip clip;

    protected virtual void Awake()
    {
        source = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();
    }
    public abstract void triggerEffect();
   
}
