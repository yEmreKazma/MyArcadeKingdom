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
        // Havuz oluþtur
        for (int i = 0; i < poolSize; i++)
        {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            enemy.SetActive(false);
            enemyPool.Add(enemy);
        }
    }

    void Update()
    {
        // Belirli bir hýzda düþman spawn et
        if (Time.time >= nextSpawnTime)
        {
            SpawnEnemy();
            nextSpawnTime = Time.time + 4f / spawnRate; // spawnRate saniyede bir spawn et
        }
    }

    void SpawnEnemy()
    {
        // Havuzdaki bir etkisiz düþmaný bul ve etkinleþtir
        for (int i = 0; i < enemyPool.Count; i++)
        {

                // Düþmanýn rastgele bir konumunu belirle
                Vector2 randomSpawnPos = Random.insideUnitCircle * spawnRadius;
                Vector3 spawnPosition = new Vector3(randomSpawnPos.x, 0f, randomSpawnPos.y) + transform.position;

                // Düþmanýn pozisyonunu belirle ve etkinleþtir
                enemyPool[i].transform.position = spawnPosition;
                enemyPool[i].SetActive(true);
                break; // Bir düþman etkinleþtirildiyse döngüyü sonlandýr
            
        }
    }

}
