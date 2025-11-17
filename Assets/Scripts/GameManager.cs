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


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemyOne", 1, 2);
        InvokeRepeating("CreateEnemyTwo", 2, 4);
        InvokeRepeating("SpawnCoin", 3, 6);
        InvokeRepeating("SpawnHealth", 3, 6);

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
        Instantiate(CoinPrefab, new Vector3(Random.Range(-9f, 9f), Random.Range(-4f, 4f), 0), Quaternion.identity);
    }
    void SpawnHealth()
    {
        Instantiate(HealthPrefab, new Vector3(Random.Range(-9f, 9f), Random.Range(-4f, 4f), 0), Quaternion.identity);
    }

}

