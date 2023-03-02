using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichShop : MonoBehaviour
{
    public int Inches = 5;
    public string ValasSandwich;

    // Start is called before the first frame update
    void Start()
    {
        ValasSandwich = SandwichShopEvaluator(Inches);
        print(ValasSandwich);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string SandwichShopEvaluator(int inches)
    {
        Inches = inches;
        if (Inches > 5)
        {
            return "Big Sandwich!!!";
        }
        else if( Inches == 5)
        {
            return "Oooh this is just right!";
        }
        else if( Inches < 5)
        {
            return "...Pathetic sandwich";
        }
        else
        {
            return "";
        }
    }
}
