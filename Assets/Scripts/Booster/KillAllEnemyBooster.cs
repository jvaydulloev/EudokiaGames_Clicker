using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillAllEnemyBooster : AbstractBooster
{
    [SerializeField] private int price=6;
    [SerializeField] private GameObject _enemySpawner;
    [SerializeField] private CountingCoin _coin;
    private void Start()
    {
        _price = price;
        
    }
    public override void Execute()
    {
        Enemy[] enemys = _enemySpawner.GetComponentsInChildren<Enemy>();

        foreach (var i in enemys)
            i.Die();

        _coin.RezetCoin();
    }
}
