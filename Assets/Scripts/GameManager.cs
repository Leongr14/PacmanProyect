using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;
    public int maxScore = 24;
    public TextMeshProUGUI scoreText;

    public GameObject gameOverUI;
    public GameObject victoryUI;

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
    }
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void Awake()
    {
        if (Instance == null) 
            Instance = this;
        else
            Destroy(gameObject);
    }
    private void Start()
    {
        UpdateScoreUI();
    }
    public void AddPoint()
    {
        score++;
        UpdateScoreUI();
        Debug.Log("Puntos: " + score);
        if (score >= maxScore)
        {
            Victory();
        }


    }
    public void Victory()
    {
        Time.timeScale = 0f;
        victoryUI.SetActive(true);
    }
    private void UpdateScoreUI()
    {
        if (scoreText != null)
            scoreText.text = "Puntos: " + score;
    }
}
