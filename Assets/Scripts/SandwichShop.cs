using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichShop : MonoBehaviour
{
    public int ValasSandwich;

    private void Start()
    {
        Debug.Log(SandwichSizeEvaluator(ValasSandwich));
    }
    public string SandwichSizeEvaluator(int inches)
    {
        if (inches < 0)
        {
            return ("Not a sandwich??");
        }
        else if (inches >= 0 && inches < 5)
        {
            return ("decent");
        }
        else if (inches >= 5 && inches < 20)
        {
            return ("good sandwich!!");
        }
        else if (inches >= 20)
        {
            return("i can't eat all that");
        }
        else return ("no sandwich number :(");
    }
}
