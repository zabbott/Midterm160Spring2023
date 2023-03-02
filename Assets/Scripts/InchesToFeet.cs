using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InchesToFeet : MonoBehaviour
{
    private void Start()
    {
        print(ConvertInchesToFeet(6));
    }

    private float ConvertInchesToFeet(float inches)
    {
        float feet = inches / 12f;
        return feet;
    }
}
