using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(RotateSprite());
        }
    }

    public IEnumerator RotateSprite()
    {
        while (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 eulerAngle = (transform.rotation.eulerAngles);
          yield return 0;
        }

      
    }

}
