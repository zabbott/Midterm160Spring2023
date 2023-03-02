using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(RotateSprite()); //Q8.4
        }
    }
    IEnumerator RotateSprite()
    {
        transform.eulerAngles += new Vector3(0, 0, -3f);
        yield return new WaitForSeconds(0.1f);
    }
}
