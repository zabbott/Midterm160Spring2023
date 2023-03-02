using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichShop : MonoBehaviour //Q9.1
{
    public int ValasSandwich;
    void Start()
    {
        Debug.Log(SandwichSizeEvaluator(ValasSandwich)); //Q9.4
    }
    string SandwichSizeEvaluator(int inches) //Q9.2
    {
        if (inches > 7)
        {
            return "How will this fit inside my mouth?";
        }
        else if (inches < 7)
        {
            return "How will this satiate my hunger?";
        }
        else
        {
            return "Satisfactory.";
        }
    } //Q9.3
}
