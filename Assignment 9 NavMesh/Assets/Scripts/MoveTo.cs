/*
* Jacob Zydorowicz
* Assignment 9
* Sets destination for nav mesh agent
*/
using UnityEngine;
using UnityEngine.AI;
public class MoveTo : MonoBehaviour
{
    public Transform goal;
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }
}
