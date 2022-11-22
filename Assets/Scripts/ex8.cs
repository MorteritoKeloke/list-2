using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex8 : MonoBehaviour
{
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        if (points > 100)
        {
            Debug.Log($"“You have more than 100 points");
        }
        else if (points <= 100 && points > 75)
        {
            Debug.Log($"You have more than 75 points, but less than or equal to 100");
        }
        else if (points<=75 && points > 50)
        {
            Debug.Log($"You have more than 50 points, but less than or equal to 75");
        }
        else if (points<=50 && points > 25)
        {
            Debug.Log($"You have more than 25 points, but less than or equal to 50");
        }
        else
        {
            Debug.Log($"You have less than or equal to 25 points");
        }

    }
}
