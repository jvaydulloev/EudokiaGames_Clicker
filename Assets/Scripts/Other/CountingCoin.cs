using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CountingCoin : MonoBehaviour
{
    public static UnityAction<int> OnCoinChanged;
    
    private int _coin;

    private void Start()
    {
        _coin = 0;
    }
    private void AddCoin() 
    {
        _coin++;
        OnCoinChanged?.Invoke(_coin);
        
    }
    private void OnEnable()
    {
        GameMode.OnDied += AddCoin;
    }
    private void OnDisable()
    {
        GameMode.OnDied -= AddCoin;
    }

    public bool TrySpendCoin(int price) 
    {
        if (_coin < price) 
            return false;
        
        _coin -= price;

        OnCoinChanged?.Invoke(_coin);
        return true;
    }
    public void RezetCoin() 
    {
        _coin = 0;
        OnCoinChanged?.Invoke(_coin);
    }
}
