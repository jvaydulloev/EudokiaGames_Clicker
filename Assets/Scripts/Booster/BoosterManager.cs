using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(KillAllEnemyBooster))]
[RequireComponent(typeof(StopTimeBooster))]
public class BoosterManager : MonoBehaviour
{
    [SerializeField] CountingCoin _coin;

    private KillAllEnemyBooster _killAllEnemyBooster;
    private StopTimeBooster _stopTimeBooster;

    private void Start()
    {
        _killAllEnemyBooster = GetComponent<KillAllEnemyBooster>();
        _stopTimeBooster = GetComponent<StopTimeBooster>();
    }
    public void TryKillAll() 
    {   int price = _killAllEnemyBooster.Price;
        if (_coin.TrySpendCoin(price)) 
        {
            _killAllEnemyBooster.Execute();
        }
    }

    public void TryStopSpawner() 
    {
        int price = _stopTimeBooster.Price;
        if (_coin.TrySpendCoin(price))
        {
            _stopTimeBooster.Execute();
        }
    }
}
