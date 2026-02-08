using UnityEngine;

public class PlayerHealth : Health
{
    protected override void Die()
    {
        base.Die();

        // gọi game over sau khi player bị hủy
        if (GameManager.Instance != null)
            GameManager.Instance.GameOver();
    }
}
