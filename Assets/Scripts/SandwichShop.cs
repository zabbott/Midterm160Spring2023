using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichShop : MonoBehaviour
{

    public float ValasSandwich;
    void Start()
    {

        SandwichSizeEvaluator(ValasSandwich);

    }

    public string SandwichSizeEvaluator(float inches)
    {

        if (inches <= 4)
        {

            print(inches.ToString("Miniscule sandwich..."));

        }

        if (inches == 5)
        {

            print(inches.ToString("Perfect sandwich!"));

        }

        if (inches >= 6)
        {

            print(inches.ToString("TOO BIG OF A SANDWICH!"));

        }

        return inches.ToString();

    }

}
