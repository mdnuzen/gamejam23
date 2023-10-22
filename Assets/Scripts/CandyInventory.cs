using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

// Keeps track of how many candies are collected

public class CandyInventory : MonoBehaviour
{

    // Other scripts can read int value, but only this script can set value
    public int NumberOfCandies;
    
    // Updates the amount of candies collected
    public void CandyCollected()
    {
        NumberOfCandies++;
    }

    public int ReturnCandyCollected()
    {
        return NumberOfCandies;
    }
}
