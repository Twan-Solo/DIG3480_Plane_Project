using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance;
    private int score = 0;

    public TextMeshProUGUI ScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake()
    {
        // Assign the singleton instance
        if (Instance == null)
        {
            Instance = this;
        }
    }
    public void AddScore(int amount)
    {
        score += amount;
        ScoreText.text = "Score: " + score;
    }
}
