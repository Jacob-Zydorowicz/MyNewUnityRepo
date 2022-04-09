/*
 * Jacob Zydorowicz
 * Assignment 7
 * Spawns enemies
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerUpPrefab;
    private float spawnRange = 9;
    public int enemyCount;
    public int waveNum = 1;

    // Start is called before the first frame update
    void Start()
    {
        spawnEnemyWave(waveNum);
        spawnPowerUp(1);
    }

    private void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if(enemyCount == 0 && waveNum <= 10)
        {
            waveNum++;
            spawnEnemyWave(waveNum);
            spawnEnemyWave(1);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    private void spawnEnemyWave(int numEnemies)
    {
        for(int i = 1; i <= numEnemies; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    private void spawnPowerUp(int num)
    {
        for (int i = 0; i < num; i++)
        {
            Instantiate(powerUpPrefab, GenerateSpawnPosition(), powerUpPrefab.transform.rotation);
        }
    }
}
