using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex5 : MonoBehaviour
{
    public int age;
    
        void Start()
    {
        if (age >= 18)
        {
            Debug.Log($"Hello, your {age} years old, so your of legal age");
        }
        else
        {
            Debug.Log($"Hello, your {age} years old, so your NOT of legal age");
        }
    }
}
