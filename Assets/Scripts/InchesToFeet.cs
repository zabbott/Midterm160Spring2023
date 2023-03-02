using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InchesToFeet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(ConvertInchesToFeet(56));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private float ConvertInchesToFeet(float inches)
    {
        return inches / 12;
    }
}
