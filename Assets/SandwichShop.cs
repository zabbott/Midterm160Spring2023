using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Question 9
/// </summary>
public class SandwichShop : MonoBehaviour
{
    public float ValasSandwich;
    //Update is love. Update is life.
    void Start()
    {
        Debug.Log(SandwichSizeEvaluator(ValasSandwich));
    }

    public string SandwichSizeEvaluator(float inches)
    {
        if (inches < 0)
            return "An impossible sized sandwich!? PROPOSTEROUS.\n CITIES SHALL BURN.";
        else if (inches == 0)
            return "no sandwich? :(";
        else if (inches < 1)
            return "AN INSULT TO SANDWICHES!";
        else if (inches < 6)
            return "Moderate. But more is to be expected";
        else if (inches < 12)
            return "Fine.";
        else if (inches == 12)
            return "FIVE DOLLAR FOOTLONG BABY!!! LETS GOOOOOOO";
        else if (inches < 20)
            return "Quite the sandwich! Huzzah!";
        else
            return "Blimey! what an enourmous sandwich!";
    }
}
