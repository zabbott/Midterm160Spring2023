using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    private int rotation;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(RotateSprite());
        }
    }
    private IEnumerator RotateSprite()
    {
        while (Input.GetKey(KeyCode.Space))
        {
            rotation += 1;
            transform.eulerAngles = new Vector3(0, 0, rotation);

            yield return null;
        }
    }
}
