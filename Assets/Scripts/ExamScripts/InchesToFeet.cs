using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InchesToFeet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ConvertInchesToFeet(69));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float ConvertInchesToFeet(float inches)
    {
        inches /= 12;
        return inches;
    }
}
