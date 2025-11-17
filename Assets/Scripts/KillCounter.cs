using TMPro;
using UnityEngine;

public class KillCounter : MonoBehaviour
{
    public static KillCounter Instance;
    private int kill = 0;

    public TextMeshProUGUI KillText;
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

    public void AddKill(int amount)
    {
        kill += amount;
        KillText.text = "Kill: " + kill;
    }
}
