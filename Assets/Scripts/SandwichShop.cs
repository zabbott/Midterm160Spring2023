using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichShop : MonoBehaviour
{
    public int ValasSandwich;

    // Start is called before the first frame update
    void Start()
    {
        print(SandwichSizeEvaluator(ValasSandwich));
    }

    public string SandwichSizeEvaluator(int sandwichSize)
    {
        if(sandwichSize < 5)
        {
            return "Insultingly inadequate"; 
        }
        if(sandwichSize < 10) 
        {
            return "Decent size";
        }
        else
        {
            return "This sandwich is massive";
        }
    }
}
