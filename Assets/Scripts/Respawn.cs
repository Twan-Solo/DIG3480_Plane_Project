using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject PlayerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider is SphereCollider)
        {
            Destroy(collision.gameObject);
 
            Instantiate(PlayerPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            Destroy(this.gameObject);
        }

    }
}
