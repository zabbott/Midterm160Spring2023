using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InchesToFeet : MonoBehaviour
{
    public void Start()
    {
        print(ConvertInchesToFeet(15)); //Change the 15 to test other numbers
    }

    public float ConvertInchesToFeet(float inches)
    {
        inches /= 12f;
        return inches;
    }
}
