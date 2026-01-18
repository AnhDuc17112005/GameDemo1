using UnityEngine;

public class BulletHit : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); // diệt enemy
            Destroy(gameObject);       // diệt bullet
        }
    }
}
