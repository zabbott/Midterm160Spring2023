using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GridBrushBase;

/// <summary>
/// Question 8
/// </summary>
public class CharacterRotation : MonoBehaviour
{
    public int Rotation=0;
    public int RotationDirection = -1;

    // Update is called once and one time only
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            RotationDirection *= -1;
            StartCoroutine(RotateSprite());
        }
    }

    public IEnumerator RotateSprite()
    {
        while (Input.GetKey(KeyCode.Space)) 
        {
            Rotation+= RotationDirection;
            gameObject.transform.eulerAngles = new Vector3(0, 0, Rotation);
            yield return null;
        }
    }
}
