using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Enemy")) return;

        Debug.Log("GAME OVER");

        // Tắt điều khiển
        var move = GetComponent<PlayerMovement>();
        if (move) move.enabled = false;

        var shoot = GetComponent<PlayerShooting>();
        if (shoot) shoot.enabled = false;

        Time.timeScale = 0f;
    }
}
