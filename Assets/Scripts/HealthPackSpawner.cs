using UnityEngine;

public class HealthPackSpawner : MonoBehaviour
{
    public GameObject healthPackPrefab;
    public float spawnInterval = 5f;
    public float spawnYRange = 3f;

    void Start()
    {
        InvokeRepeating("SpawnHealthPack", 3f, spawnInterval);
    }

    void SpawnHealthPack()
    {
        float randomY = Random.Range(-spawnYRange, spawnYRange);
        Vector3 spawnPos = new Vector3(10f, randomY, 0f);

        Instantiate(healthPackPrefab, spawnPos, Quaternion.identity);
    }
}