using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex4 : MonoBehaviour
{
    public float base1;
    public float height;
    private float triangle;

    void Start()
    {
        if (base1 > 0 && height > 0)
        {
            triangle = base1 * height / 2;
            Debug.Log($"The area of the triangle is {triangle}");
        }
        else
        {
            Debug.Log($"The area cannot be calculated");
        }

    }
}
