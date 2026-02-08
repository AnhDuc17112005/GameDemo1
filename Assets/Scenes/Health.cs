using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("VFX")]
    public GameObject explosionPrefab;

    [Header("HP")]
    public int defaultHealthPoint = 1;
    protected int healthPoint;

    protected virtual void Start()
    {
        healthPoint = defaultHealthPoint;
    }

    public virtual void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;

        healthPoint -= damage;
        if (healthPoint <= 0) Die();
    }

    protected virtual void Die()
    {
        if (explosionPrefab != null)
        {
            var fx = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(fx, 1f);
        }

        Destroy(gameObject);
    }
}
