using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2f;
    public float spawnYRange = 2f;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1f, spawnInterval);
    }

    void SpawnObstacle()
    {
        float randomY = Random.Range(-spawnYRange, spawnYRange);
        Vector3 spawnPos = new Vector3(10f, randomY, 0f);

        Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
    }
}