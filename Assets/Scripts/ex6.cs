using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex6 : MonoBehaviour
{
    public float totalDistance;
    public float distanceTraveled;
    public float result;

    void Start()
    {
        if (distanceTraveled >= totalDistance)
        {
            Debug.Log($"Congratulations! You have completed the total distance");
        }
        else
        {
            result = totalDistance - distanceTraveled;
            Debug.Log($"oh… You still have {result} meters left to complete the total distance.");
        }
    }
}
