using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;
    public TextMeshProUGUI scoreText;

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
        
    }
    private void UpdateScoreUI()
    {
        if (scoreText != null)
            scoreText.text = "Puntos: " + score;
    }
}
