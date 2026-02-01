using UnityEngine;

public class BulletHit : MonoBehaviour
{
    public GameObject enemyExplosionPrefab;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            // tạo hiệu ứng nổ
            Instantiate(enemyExplosionPrefab, other.transform.position, Quaternion.identity);

            GameManager.Instance.AddScore(10);
            // huỷ enemy
            Destroy(other.gameObject);

            // huỷ đạn
            Destroy(gameObject);
        }
    }
}
