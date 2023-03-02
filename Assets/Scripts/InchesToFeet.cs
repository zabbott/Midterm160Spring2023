using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InchesToFeet : MonoBehaviour
{

    private void Start()
    {
        Debug.Log(ConvertInchesToFeet(60));
    }
    public int ConvertInchesToFeet (int Inches)
    {
        return (Inches / 12);
    }
}
