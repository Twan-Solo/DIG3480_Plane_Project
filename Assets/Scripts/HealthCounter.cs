using TMPro;
using UnityEngine;


public class HealthCounter : MonoBehaviour
{
    public static HealthCounter Instance;
    private int health = 0;

    public TextMeshProUGUI HealthText;
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
    public void AddHealth(int amount)
    {
        health += amount;
        HealthText.text = "Health: " + health;
    }
}
