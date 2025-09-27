using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemyCount;

    public int waveNumber = 1;
    private float spawnRange = 9;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        SpawnEnemyWave(waveNumber);
    }

    void Update() {
        enemyCount = FindObjectsByType<Enemy>(FindObjectsSortMode.None).Length;
        if (enemyCount == 0)
        {
            if (waveNumber < 10)
            {
                waveNumber++;
            }
            SpawnEnemyWave(waveNumber);
        }
    }

    void SpawnEnemyWave(int spawnCount) {
        for (int i = 0; i < spawnCount; i++)
        {
            Instantiate(enemyPrefab, GenerateRandomSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateRandomSpawnPosition() {
        float spawnCoordX = Random.Range(-spawnRange, spawnRange);
        float spawnCoordZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPositon = new Vector3(spawnCoordX, 0, spawnCoordZ);
        return randomPositon;
    }
}
