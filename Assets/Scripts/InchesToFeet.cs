using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InchesToFeet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(ConvertInchesToFeet(18) + " feet");
    }

    public float ConvertInchesToFeet(int inches)
    {
        return inches / 12.0f;
    }
}
