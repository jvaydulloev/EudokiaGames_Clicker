using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameMode : MonoBehaviour
{
    private int _enemiesCount;
    public static UnityAction OnGameOver;
    public static UnityAction OnStartedGame;
    public static UnityAction OnSpawned;
    public static UnityAction OnDied;

    private void Start()
    {
        OnStartedGame?.Invoke();
    }
    private void OnEnable()
    {
        OnSpawned += AddCount;
        OnDied += ReduceCount;
        OnGameOver += DataHolder.TrySetNewData;
    }

    private void OnDisable()
    {
        OnSpawned -= AddCount;
        OnDied -= ReduceCount;
        OnGameOver -= DataHolder.TrySetNewData;
    }
    private void AddCount() 
    {
        _enemiesCount++;
        TryGameOver();
    }
    private void ReduceCount() 
    {
        _enemiesCount--;
    }
    private void TryGameOver() 
    {
        if (_enemiesCount >= 11)
            OnGameOver?.Invoke();
    }
}
