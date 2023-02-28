using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sandwhiches : MonoBehaviour
{
    public float ValasSandwhich;

    private void Start()
    {
        print(SandwhichSizeEvaluator(33));
    }

    public string SandwhichSizeEvaluator(float inches)
    {
        if(inches > 0 && inches < 6)
        {
            return "Small sad sandwich"; 
        }
        else if(inches >=6 && inches < 12)
        {
            return  "Good size sandwhich...but could be better"; 
        }
        else
        {
            return "oh EXCCELLENT sandwich";
        }
    }
}
