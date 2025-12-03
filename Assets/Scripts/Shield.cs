using UnityEngine;

public class Shield : MonoBehaviour
{
    public float lifetime = 5f;
    public AudioClip powerUpSound;
    public AudioClip powerDownSound;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.shieldStartSound = powerUpSound;
                player.shieldEndSound = powerDownSound;
                player.ActivateShield(lifetime);
            }

            Destroy(gameObject);
        }

        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
