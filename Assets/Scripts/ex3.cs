using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex3 : MonoBehaviour
{
    public int x;
    void Start()
    {
        if (x % 5 == 0)
        {
            Debug.Log($"This number is divisible by 5");
        }
        else
        {
            Debug.Log($"this number isn't divisible by 5");
        }
    }
        
    }