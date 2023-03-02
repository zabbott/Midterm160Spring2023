using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InchesToFeet : MonoBehaviour
{
    public int Inches = 12;
    public int Feet = 1;
    public int InchesInAFoot;


    // Start is called before the first frame update
    void Start()
    {
        ConvertInchesToFeet(Inches, Feet);
    }

    public void ConvertInchesToFeet(int inches, int feet)
    {
        Inches = inches;
        Feet = feet;
        InchesInAFoot = (Inches * Feet);
        Debug.Log("There are " + InchesInAFoot + " inches in " + Feet + " foot");
        return;
    }
}
