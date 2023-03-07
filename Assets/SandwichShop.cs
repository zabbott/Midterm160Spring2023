using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichShop : MonoBehaviour
{
    public int ValasSandwich;
    void Start()
    {
        print(SandwichSizeEvaluator(ValasSandwich));
    }

    public string SandwichSizeEvaluator(int Inches)
    {
        if(Inches < 4)
        {
            return "WHAT IS THAT THIS IS INSAULTING TO THE BEST PUPPER VALA";
        }
        else if(Inches < 18)
        {
            return "Better I guess but that is all you are going to bring for Vala?";
        }
        else
        {
            return "Finally A meal fit for a queen like vala";
        }
    }
}
