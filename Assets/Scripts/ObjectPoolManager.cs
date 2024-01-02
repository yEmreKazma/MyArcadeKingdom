using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolManager : MonoBehaviour
{
    public GameObject enemyPrefab; // Reference to the enemy prefab
    public float spawnInterval = 0.2f; // Time interval between enemy spawns
    public int maxEnemies = 10; // Maximum number of enemies to spawn

    public float spawnRate = 2f;
    public float spawnRadius = 7f;

    private int currentEnemyCount = 0;

    void Start()
    {
        // InvokeRepeating allows us to repeatedly call a method with a delay
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        if (currentEnemyCount < maxEnemies)
        {
            // Choose a random spawn point
             Vector2 randomSpawnPos = Random.insideUnitCircle * spawnRadius;
               Vector3 spawnPosition = new Vector3(randomSpawnPos.x, 0f, randomSpawnPos.y) + transform.position;

            // Instantiate an enemy at the chosen spawn point
            GameObject newEnemy = Instantiate(enemyPrefab, spawnPosition, transform.rotation);
            newEnemy.transform.SetParent(transform);
            // Increment the enemy count
            currentEnemyCount++;
            Debug.Log(currentEnemyCount);
        }
    }
}
