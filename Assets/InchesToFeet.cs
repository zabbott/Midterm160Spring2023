using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InchesToFeet : MonoBehaviour
{
    void Start()
    {
        Debug.Log(ConvertInchesToFeet(48)); //Q1.2
    }
    int ConvertInchesToFeet(int inches)
    {
        inches = inches / 12;
        return inches; //Q1.1
    }
}
