using TMPro;
using UnityEngine;


public class HealthCounter : MonoBehaviour
{
    public static HealthCounter Instance;
    private int health = 0;
    public int CurrentHealth => health;

    public TextMeshProUGUI HealthText;
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
    public void AddHealth(int amount)
    {
        health += amount;
        HealthText.text = "Health: " + health;
    }
}
