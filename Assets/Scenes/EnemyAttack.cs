using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public EnemyHealth health;
    public int damage = 1;

    private void Reset()
    {
        health = GetComponent<EnemyHealth>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var playerHealth = other.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);

            // enemy tự chết khi húc
            if (health != null)
                health.TakeDamage(9999);
        }
    }
}
