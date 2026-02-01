using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject gameOverPanel;
    public bool isGameOver = false;
    public int score = 0;

    public void AddScore(int amount)
    {
        if (isGameOver) return;

        score += amount;

        if (ScoreUI.Instance != null)
            ScoreUI.Instance.UpdateScore(score);
    }


    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void GameOver()
    {
        if (isGameOver) return;

        isGameOver = true;

        // Hiện UI Game Over
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);

        // Dừng game
        Time.timeScale = 0f;
    }
}
