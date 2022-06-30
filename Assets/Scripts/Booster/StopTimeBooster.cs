using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTimeBooster :AbstractBooster
{
    [SerializeField] private int price = 6;
    [SerializeField] private GameObject _enemySpawner;

    private EnemySpawner enemySpawner;
    private void Start()
    {
        _price = price;
    }
    public override void Execute()
    {
        enemySpawner = _enemySpawner.GetComponent<EnemySpawner>();
        StartCoroutine(StopSpawnTime());
    }

    private IEnumerator StopSpawnTime() 
    {
        enemySpawner.SetPremissionToSpawn(false);
        yield return new WaitForSeconds(3f);
        enemySpawner.SetPremissionToSpawn(true);
    }

   
}
