using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            var position = new Vector3(Random.Range(-5, 5f), 0, Random.Range(-5, 5f));

            Instantiate(enemyPrefab, position, Quaternion.identity);
        }
        
    }
}
