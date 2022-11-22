using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex10 : MonoBehaviour
{
    public int year;
    void Start()
    {
        if (year % 4 == 0 && year % 100 != 0 ||year % 400 == 0)
        {
            Debug.Log($"{year} is a leap year");
        }
        else
        {
            Debug.Log($"{year} is not a leap year");
        }
    }
}