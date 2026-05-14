using UnityEngine;
using TMPro;

public class GameManagerL6 : MonoBehaviour
{
    public static GameManagerL6 instance;

    [Header("Player")]
    public int lives = 3;

    [Header("Score")]
    public float score;

    [Header("UI")]
    public TMP_Text scoreText;
    public TMP_Text livesText;
    public GameObject gameOverText;

    private bool gameEnded = false;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (gameEnded)
            return;

        score += Time.deltaTime;

        scoreText.text =
            "Score: " + Mathf.FloorToInt(score);

        livesText.text =
            "Lives: " + lives;
    }

    public void LoseLife()
    {
        lives--;

        if (lives <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        gameEnded = true;

        gameOverText.SetActive(true);

        Time.timeScale = 0;
    }
}