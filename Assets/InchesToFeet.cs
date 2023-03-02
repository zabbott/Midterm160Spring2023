using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Question 1
/// </summary>
public class InchesToFeet : MonoBehaviour
{

    // Update is called before the first frame update
    void Start()
    {
        Debug.Log("15.4 Inches => " + ConvertInchesToFeet(15.4f));
    }

    // Update is called once per frame
    public float ConvertInchesToFeet(float inches)
    {
        return inches / 12;
    }
}
