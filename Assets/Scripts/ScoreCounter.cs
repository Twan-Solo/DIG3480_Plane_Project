using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance;
    private int score = 0;

    public TextMeshProUGUI ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake()
    {
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
