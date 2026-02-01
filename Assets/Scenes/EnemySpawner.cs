using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 1.0f;
    public float padding = 0.5f;
    public float spawnY = 6f;

    float timer;

    void Update()
    {
        if (GameManager.Instance != null && GameManager.Instance.isGameOver)
            return;
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            Spawn();
            timer = 0f;
        }
    }

    void Spawn()
    {
        Camera cam = Camera.main;
        float halfH = cam.orthographicSize;
        float halfW = halfH * cam.aspect;

        float x = Random.Range(-halfW + padding, halfW - padding);
        Vector3 pos = new Vector3(x, halfH + 1f, 0f); // luôn ở trên màn hình 1 chút
        Instantiate(enemyPrefab, pos, Quaternion.identity);
    }
}
