using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint2 : MonoBehaviour
{
    // Start is called before the first frame update
    int Sum(int x,int y)
    {
        return x + y;
    }

    int Pod(int x,int y)
    {
        return x * y;
    }

    int Div(int x,int y)
    {
        if (y == 0)
        {
            Console.WriteLine("Cannot divide by Zero");
            return 0;
        }
        return x / y;
    }
}
