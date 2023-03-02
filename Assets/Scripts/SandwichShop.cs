using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichShop : MonoBehaviour
{
    public float ValasSandwich = 7;

    // Start is called before the first frame update
    void Start()
    {
        SandwichSizeEvaluator(ValasSandwich);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string SandwichSizeEvaluator(float inches)
    {
        if (inches <= 4)
        {
            return "Maybe snack???";
        }

        else if (inches <= 9)
        {
            return "Decent meal...";
        }

        else
        {
            return "Leftover City!!!<3";
        }
    }
}
