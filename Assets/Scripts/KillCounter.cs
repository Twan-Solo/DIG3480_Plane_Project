using TMPro;
using UnityEngine;

public class KillCounter : MonoBehaviour
{
    public static KillCounter Instance;
    private int kill = 0;

    public TextMeshProUGUI KillText;
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

    public void AddKill(int amount)
    {
        kill += amount;
        KillText.text = "Kill: " + kill;
    }
}
