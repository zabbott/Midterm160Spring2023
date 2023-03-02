using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwhichShop : MonoBehaviour
{
    public int ValasSandwhich;

    public void Start()
    {
        print(SizeEvaluator(ValasSandwhich));
    }

    public string SizeEvaluator(int inches)
    {
        if (inches < 3)
            return ("Smol");
        else if (inches < 12)
            return ("Acceptable");
        else
            return ("Only the best for Lady Vala :)");
    }
}
