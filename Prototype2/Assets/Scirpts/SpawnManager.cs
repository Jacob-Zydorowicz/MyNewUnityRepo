/*
 * Jacob Zydorowicz
 * Assignment 3 Prototype2
 * Spawns enemies at random locations from top of screen
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabsToSpawn;


    private float left = -18;
    private float right = 18;
    private float spawnPosZ = 20;
    public bool gameOver =false;

    public HealthSystem healthSys;



    private void Start()
    {
        healthSys = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
        StartCoroutine(spawnRandomPrefabWithCouroutine());
    }

    

    //Method to spawn a random prefab of the list of animal prefabs at a random xposition
    void  spawnRandomPrefab()
    {
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);
        Vector3 spawnPos = new Vector3(Random.Range(left, right), 0, spawnPosZ);
        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }

    IEnumerator spawnRandomPrefabWithCouroutine()
    {
        yield return new WaitForSeconds(3f);

        while(!healthSys.gameOver)
        {
            spawnRandomPrefab();

            float randomDely = Random.Range(0.8f, 3f);

            yield return new WaitForSeconds(randomDely);
        }
    }
}
