using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CountingScore : MonoBehaviour
{
    public static UnityAction<float> OnScoreChanged;
    
    public int Score 
    {
        get; 
        private set; 
    }

    private void OnEnable()
    {
        GameMode.OnDied += AddPoint;
    }

    private void OnDisable()
    {
        GameMode.OnDied -= AddPoint;
    }
    private void  AddPoint() 
    {
        Score+=10;
        OnScoreChanged?.Invoke(Score);
    }

}
