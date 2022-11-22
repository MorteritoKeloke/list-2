using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex7 : MonoBehaviour
{
    public string calc;
    public float x;
    public float y;
    private float result;

    // Start is called before the first frame update
    void Start()
    {
        if (calc == "sum")
        {
            result = x + y;
            Debug.Log($"{x} + {y} = {result}");
        }
        else if (calc == "subtraction") 
        {
            result = x - y;
            Debug.Log($"{x} - {y} = {result}");
        }
        else if (calc == "product")
        {
            result = x * y;
            Debug.Log($"{x} * {y} = {result}");
        }
        else if (calc == "division")
        {
            result = x / y;
            Debug.Log($"{x} / {y} = {result}");
        }
    }
}
