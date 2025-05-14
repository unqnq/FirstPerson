using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public Transform player;
    public float spawnInterval = 3f;
    public float minSpawnInterval = 0.5f;
    public float spawnDistanceFromCenter = 20f;
    public float spawnIntervalDecreaseRate = 0.05f;
    public float timeToNextDecrease = 10f;
    private float timer = 0f;
    private float difficultyTimer = 0f;
    public bool canSpawn = true;

    private void Update()
    {
        timer += Time.deltaTime;
        difficultyTimer += Time.deltaTime;
        if (timer >= spawnInterval && canSpawn)
        {
            SpawnEnemy();
            timer = 0f;
        }

        if (difficultyTimer >= timeToNextDecrease)
        {
            spawnInterval = Mathf.Max(minSpawnInterval, spawnInterval - spawnIntervalDecreaseRate);
            difficultyTimer = 0f;
        }
    }

    void SpawnEnemy()
    {
        // Випадковий напрямок по колу
        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        Vector3 spawnPos = new Vector3(randomDirection.x, 0, randomDirection.y) * spawnDistanceFromCenter;
        spawnPos.y = 5;
        int prefabIndex = (Random.value < 0.7f) ? 0 : 1;
        GameObject enemy = Instantiate(enemyPrefab[prefabIndex], spawnPos, Quaternion.identity);
        enemy.GetComponent<EnemyAI>().SetTarget(player);
    }
}
