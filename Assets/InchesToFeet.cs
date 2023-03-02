using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InchesToFeet : MonoBehaviour
{
    public int Inches = 12;
    public int Feet = 1;
    public float Conversion;

    // Start is called before the first frame update
    void Start()
    {
        //commenting however i want :p xD O_o
        ConvertInchesToFeet(Inches, Feet);
        //pleasedontfailme
        //hi

    }

    public void ConvertInchesToFeet(int inches, int feet)
    {
        Inches = inches;
        Feet = feet;
        Conversion = (Inches * Feet);
        Debug.Log("There are " + Conversion + " inches in " + Feet + " foot/feet.");
    }
}
