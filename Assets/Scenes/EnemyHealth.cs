using UnityEngine;

public class EnemyHealth : Health
{
    [Header("Score")]
    public int scoreWhenDie = 10;

    protected override void Die()
    {
        // cộng điểm trước khi hủy
        if (GameManager.Instance != null)
            GameManager.Instance.AddScore(scoreWhenDie);

        base.Die();
    }
}
