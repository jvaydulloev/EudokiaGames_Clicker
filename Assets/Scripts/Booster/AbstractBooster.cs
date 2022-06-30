using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractBooster : MonoBehaviour
{
    protected int _price;

    public int Price
    {
        get => _price; 
        private set =>_price = value;
    }
    public abstract void Execute();
}
