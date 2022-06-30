using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition
{
    public static Vector3 GetRandomPosition() 
    {

        int index_x = UnityEngine.Random.Range(-9,9);
        index_x = (index_x % 2 == 0) ? index_x + 1 : index_x;
        int index_y = UnityEngine.Random.Range(-9, 9);
        index_y = (index_y % 2 == 0) ? index_y + 1 : index_y;

        return new Vector3(index_x,0,index_y);
    }
}
