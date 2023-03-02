using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwhichShop : MonoBehaviour
{
    public float ValasSandwhich;
    // Start is called before the first frame update
    void Start()
    {
        print (SandwhichSizeEvaluator(ValasSandwhich));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private string SandwhichSizeEvaluator(float inches)
    {
        if (inches < 5)
            return "Its average ;)";

        else if (inches < 10)
            return "Its a very big!!!";

        else
            return "It's ginormous!!!!";
    }
}
