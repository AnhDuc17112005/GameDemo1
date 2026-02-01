using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    public GameObject playerExplosionPrefab;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Enemy")) return;

        // Nổ player
        Instantiate(playerExplosionPrefab, transform.position, Quaternion.identity);

        // GỌI GAME OVER
        GameManager.Instance.GameOver();

        // Ẩn player
        gameObject.SetActive(false);
    }
}
