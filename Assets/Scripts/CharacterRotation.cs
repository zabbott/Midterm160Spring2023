using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    // Start is called before the first frame update
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
            gameObject.transform.eulerAngles += new Vector3(0f, 0f, .5f);
            yield return null;
        }
    }
}
