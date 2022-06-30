using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin_Text : MonoBehaviour
{
    private TextMeshProUGUI _text;
    public void SetText(int current)
    {
        _text.text =current.ToString();
    }
    private void OnEnable()
    {
        CountingCoin.OnCoinChanged += SetText;
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void OnDisable()
    {
        CountingCoin.OnCoinChanged -= SetText;
    }
}
