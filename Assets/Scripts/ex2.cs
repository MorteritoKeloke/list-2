using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex2 : MonoBehaviour
{
    public int year;
    private int horoscopo;

    void Start()
    {
        horoscopo = year % 12;

        if (horoscopo == 0)
        {
            Debug.Log($"Your horoscop is the monkey ");
        }
        else if (horoscopo == 1)
        {
            Debug.Log($"Your horoscop is the chiken ");
        }
        else if (horoscopo == 2)
        {
            Debug.Log($"Your horoscop is the dog ");
        }
        else if (horoscopo == 3)
        {
            Debug.Log($"Your horoscop is the pig ");
        }
        else if (horoscopo == 4)
        {
            Debug.Log($"Your horoscop is the rat ");
        }
        else if (horoscopo == 5)
        {
            Debug.Log($"Your horoscop is the buey ");
        }
        else if (horoscopo == 6)
        {
            Debug.Log($"Your horoscop is the tiger ");
        }
        else if (horoscopo == 7)
        {
            Debug.Log($"Your horoscop is the rabbit ");
        }
        else if (horoscopo == 8)
        {
            Debug.Log($"Your horoscop is the dragon ");
        }
        else if (horoscopo == 9)
        {
            Debug.Log($"Your horoscop is the snake ");
        }
        else if (horoscopo == 10)
        {
            Debug.Log($"Your horoscop is the horse ");
        }
        else
        {
            Debug.Log($"Your horoscop is the sheep ");
        }
    }
}