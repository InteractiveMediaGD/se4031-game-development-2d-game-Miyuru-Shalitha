using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 3f;
    public float spawnYRange = 3f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2f, spawnInterval);
    }

    void SpawnEnemy()
    {
        float randomY = Random.Range(-spawnYRange, spawnYRange);
        Vector3 spawnPos = new Vector3(10f, randomY, 0f);

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}