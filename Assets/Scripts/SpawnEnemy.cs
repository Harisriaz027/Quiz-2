using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    void Start()
    {
        
        InvokeRepeating("SpawnNewEnemy", 2, 10);
    }

     void SpawnNewEnemy()
    {
        Instantiate(enemyPrefab, new Vector3(23, 1, 29), enemyPrefab.transform.rotation);
       Instantiate(enemyPrefab, new Vector3(-23, 1, 29), enemyPrefab.transform.rotation);
        Instantiate(enemyPrefab, new Vector3(-23, 1, -29), enemyPrefab.transform.rotation);
        Instantiate(enemyPrefab, new Vector3(23, 1, -29), enemyPrefab.transform.rotation);
    }
}
