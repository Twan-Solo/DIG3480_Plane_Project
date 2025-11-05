using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        float randomSpawn = Random.Range(-9f, 9f);
        transform.position = new Vector3(randomSpawn, 6.5f, 0);

        float randomHorizontal = Random.Range(-1f, 1f);

        direction = new Vector3(randomHorizontal, -1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime * 3f);
        if (transform.position.y < -6.5f || transform.position.x<-9.5f || transform.position.x> 9.5f)
        {
            Destroy(this.gameObject);
        }
    }

}