using UnityEngine;

public class Coin : MonoBehaviour
{
    public float lifetime = 5f;  // Coin destroys itself after 5 seconds
    public int scoreValue = 1;   // Score added when player collects

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (ScoreCounter.Instance != null)
                ScoreCounter.Instance.AddScore(scoreValue);

            Destroy(gameObject);
        }

        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
