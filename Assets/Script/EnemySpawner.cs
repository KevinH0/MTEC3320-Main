using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++){
            Vector3 position = new Vector3(Random.Range(-10f, 10f), 1.0f, Random.Range(-10f, 10f));
            Quaternion rotation = Quaternion.identity;
            GameObject go = Instantiate(enemyPrefab, position, rotation);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
