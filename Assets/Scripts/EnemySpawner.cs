using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
public class EnemySpawner : MonoBehaviour
{

    /*private void Update()
    {
        if (transform.childCount ==0)
        {
            BattleManager.Instance.BattleWon();
        }
    }*/

    public GameObject enemyPrefab;
    public int poolSize = 10;
    public float spawnRate = 2f;
    public float spawnRadius = 5f;

    private List<GameObject> enemyPool = new List<GameObject>();
    private float nextSpawnTime = 5f;

    void Start()
    {
        // Havuz olu�tur
        for (int i = 0; i < poolSize; i++)
        {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            enemy.SetActive(false);
            enemyPool.Add(enemy);
        }
    }

    void Update()
    {
        // Belirli bir h�zda d��man spawn et
        if (Time.time >= nextSpawnTime)
        {
            SpawnEnemy();
            nextSpawnTime = Time.time + 4f / spawnRate; // spawnRate saniyede bir spawn et
        }
    }

    void SpawnEnemy()
    {
        // Havuzdaki bir etkisiz d��man� bul ve etkinle�tir
        for (int i = 0; i < enemyPool.Count; i++)
        {

                // D��man�n rastgele bir konumunu belirle
                Vector2 randomSpawnPos = Random.insideUnitCircle * spawnRadius;
                Vector3 spawnPosition = new Vector3(randomSpawnPos.x, 0f, randomSpawnPos.y) + transform.position;

                // D��man�n pozisyonunu belirle ve etkinle�tir
                enemyPool[i].transform.position = spawnPosition;
                enemyPool[i].SetActive(true);
                break; // Bir d��man etkinle�tirildiyse d�ng�y� sonland�r
            
        }
    }

}
