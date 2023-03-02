using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InchesToFeet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ConvertInchesToFeet(28);
    }

    public void ConvertInchesToFeet(float inches)
    {
        float Feet = (inches / 12);
        Debug.Log(inches + " inches equals " + Feet + " feet.");
    }
}
