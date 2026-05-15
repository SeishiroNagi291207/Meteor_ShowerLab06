using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerL6 : MonoBehaviour
{
    public static GameManagerL6 instance;

    [Header("Lives")]
    public int lives = 3;

    [Header("Hearts")]
    public Image[] hearts;

    [Header("Score")]
    public float score;

    public TMP_Text scoreText;

    [Header("Game Over")]
    public GameObject gameOverText;

    public GameObject restartButton;

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
    }

    public void LoseLife()
    {
        lives--;

        UpdateHearts();

        if (lives <= 0)
        {
            GameOver();
        }
    }

    void UpdateHearts()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].enabled = i < lives;
        }
    }

    void GameOver()
    {
        gameEnded = true;

        gameOverText.SetActive(true);

        restartButton.SetActive(true);

        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}