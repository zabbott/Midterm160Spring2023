using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(RotateSprite());
        }
    }

    public IEnumerator RotateSprite()
    {
        while(Input.GetKey(KeyCode.Space))
        {
            transform.eulerAngles += new Vector3(0, 0, 1);
            yield return null;
        }
    }
}
