using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InchesToFeet : MonoBehaviour
{
    void Start()
    {
        print(ConvertInchesToFeet(12343925));
    }
    
    public float ConvertInchesToFeet(int inch)
    {
        return inch / 12;
    }
}
