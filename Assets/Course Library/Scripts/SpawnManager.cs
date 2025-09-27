using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        Instantiate(enemyPrefab, GenerateRandomSpawnPosition(), enemyPrefab.transform.rotation);
    }

    private Vector3 GenerateRandomSpawnPosition() {
        float spawnCoordX = Random.Range(-spawnRange, spawnRange);
        float spawnCoordZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPositon = new Vector3(spawnCoordX, 0, spawnCoordZ);
        return randomPositon;
    }
}
