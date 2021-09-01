using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject EnemyPrefab;
    [SerializeField] [Range(0, 50)] int poolSize = 5;
    [SerializeField] [Range(0.1f, 30f)] float spawnTimer = 1f;

    GameObject[] pool;


    private void Awake()
    {
        PopulatePool();
    }
    void PopulatePool()
    {
        pool = new GameObject[poolSize];

        for (int i = 0; i < pool.Length; i++ ) {
            pool[i] = Instantiate(EnemyPrefab, transform);
            pool[i].SetActive(false);
        }



    }
    // Update is called once per frame
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    } 
    
    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            EnableObjectInPool();
            yield return new WaitForSeconds(spawnTimer);
            
        }
    }
    void EnableObjectInPool()
    {
        for (int i = 0; i < pool.Length; i++)
        {   
            // if object in the lowest heirachy active is false then run.
            if (!pool[i].activeInHierarchy)
            {
                pool[i].SetActive(true);
                return;
            }
        }
    }
}