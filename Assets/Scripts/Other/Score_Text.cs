using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_Text : MonoBehaviour
{
    private TextMeshProUGUI _text;
    public void SetText(float current) 
    {
        _text.text = "Score: "+current.ToString();
    }
    private void OnEnable()
    {
        CountingScore.OnScoreChanged += SetText;
        CountingScore.OnScoreChanged += DataHolder.SetCandidateForRecord;
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void OnDisable()
    {
        CountingScore.OnScoreChanged -= SetText;
        CountingScore.OnScoreChanged += DataHolder.SetCandidateForRecord;
    }
}
