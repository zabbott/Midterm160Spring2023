using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(RotateSprite());
        }
    }

    //I THINK IT'S INFINITE -- accidentally used update (horrible!) -- ok update redemption arc
    public IEnumerator RotateSprite()
    {
        while (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.eulerAngles += new Vector3(0, 0, 5);
            yield return null;
        }
    }
}
/// come back vbds;jukGBEFJU:LOB;
