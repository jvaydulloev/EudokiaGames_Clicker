using System.Collections;                                        
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Records : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] _texts;
  
    public void PrintToTable() 
    {
        float[] _records = DataHolder.GetData();
        for (int i=0; i<5;i++)
            _texts[i].text = _records[i].ToString();
    }
    private void OnEnable()
    {
        PrintToTable();
    }

}
