using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1 : MonoBehaviour
{
    public float x;
   
    void Start()
    {
      if (x> 0)
        {
            Debug.Log($"The number {x} is positive");
        }  
      else if (x < 0)
        {
            Debug.Log($"The number {x} is negative");
        }
      else
        {
            Debug.Log($"It's number {x} ");
        }
    }
}
