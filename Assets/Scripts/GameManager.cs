using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject enemyOnePrefab;
    public GameObject enemyTwoPrefab;
    public GameObject PlayerPrefab;
    public GameObject CoinPrefab;
    public GameObject HealthPrefab;
    public GameObject ShieldPrefab;
    private float horizontalScreenLimit = 9.5f;
    private float verticalScreenLimit = 6.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemyOne", 1, 2);
        InvokeRepeating("CreateEnemyTwo", 2, 4);
        InvokeRepeating("SpawnCoin", 3, 6);
        InvokeRepeating("SpawnHealth", 3, 6);
        InvokeRepeating("SpawnShield", 3, 6);

    }
    
    // Update is called once per frame
    void Update()
    {
       
    }

    void CreateEnemyOne()
    {
        Instantiate(enemyOnePrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
 
    }

   void CreateEnemyTwo()
    {
        Instantiate(enemyTwoPrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
    }
    void SpawnCoin()
    {
        Instantiate(CoinPrefab, new Vector3(Random.Range(-horizontalScreenLimit, horizontalScreenLimit), Random.Range(-verticalScreenLimit / 2f, verticalScreenLimit / 4f), 0), Quaternion.identity);
    }
    void SpawnHealth()
    {
        if (HealthCounter.Instance != null && HealthCounter.Instance.CurrentHealth < 3)
        {
            Instantiate(HealthPrefab, new Vector3(Random.Range(-horizontalScreenLimit, horizontalScreenLimit), Random.Range(-verticalScreenLimit / 2f, verticalScreenLimit / 4f), 0), Quaternion.identity);
        }
    }

    void SpawnShield()
    {
        Instantiate(ShieldPrefab, new Vector3(Random.Range(-horizontalScreenLimit, horizontalScreenLimit), Random.Range(-verticalScreenLimit / 2f, verticalScreenLimit / 4f), 0), Quaternion.identity);
    }

}

