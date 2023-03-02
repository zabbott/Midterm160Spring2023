using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichShop : MonoBehaviour
{
    public int Inches = 1;
    public string ValasSandwich;

    // Start is called before the first frame update
    void Start()
    {
        ValasSandwich = SandwichSizeEvaluator(Inches);
        print(ValasSandwich);
    }

    public string SandwichSizeEvaluator(int inches)
    {
        Inches = inches;
        if(inches < 12) //fivedollarfivedollarfivedollarfootlongs
        {
            return "SCOFF what is this peasant meal *spits*";
        }
        else if(inches == 12)
        {
            return "ah yes a scrumptious five dollar footlong";
        }
        else if(inches > 12)
        {
            return "wow ... truly a feast fit for a king";
        }
        else
        {
            return "";
        }
    }
}
