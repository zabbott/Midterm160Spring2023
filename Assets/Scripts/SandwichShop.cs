using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichShop : MonoBehaviour
{
    public float ValasSandwich;

    private void Start()
    {
        print(SandwichSizeEvaluator(ValasSandwich));
    }
    private string SandwichSizeEvaluator(float inches)
    {

        if (inches < 0)
        {
            return "how the hell do you have a sandwich with negative length";
        }
        if (inches >= 0 && inches < 5)
        {
            return "too small";
        }
        if (inches >= 5 && inches < 10)
        {
            return "perfect";
        }
        if (inches >= 10)
        {
            return "that's quite large";
        }
        else
        {
            return "Impossible!!";
        }

    }
    
}
