using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichShop : MonoBehaviour
{
    public float valasSandwhich;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(SandwichSizeEvaluator(valasSandwhich));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private string SandwichSizeEvaluator(float inches)
    {
        if(inches >= 100)
        {
            return "way too biiiiiiiiig sandwich";
        }
        if(inches > 0)
        {
            return "satisfactory sandwich size";
        }
        else
        {
            return "where is sandwich GIVE ME SANDWICH";
        }
    }
}
