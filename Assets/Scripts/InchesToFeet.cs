using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InchesToFeet : MonoBehaviour
{
    const int inchesPerFoot = 12;
    public float Inches = 0.0f;
    float feet = 0.0f;

    void Start()
    {

        ConvertInchesToFeet(Inches);
        Debug.Log(Inches + " inches equates to " + feet + " feet.");

    }

   public void ConvertInchesToFeet(float inches)
    {

        feet = inches / inchesPerFoot;
        return;

    }
}
