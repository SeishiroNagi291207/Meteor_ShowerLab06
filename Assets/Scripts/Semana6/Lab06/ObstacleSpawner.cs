using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [Header("Obstacle Settings")]
    public GameObject[] obstacles;

    public float spawnRate = 2f;

    [Header("Spawn Area")]
    public float rangeX = 10f;
    public float rangeY = 5f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 1f, spawnRate);
    }

    void SpawnObstacle()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-rangeX, rangeX),Random.Range(-rangeY, rangeY),30f);

        int randomIndex = Random.Range(0, obstacles.Length);

        Instantiate(obstacles[randomIndex],spawnPosition,Quaternion.identity);
    }
}