using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

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
        while (Input.GetKey(KeyCode.Space))
        {
            Vector3 NewRotate = transform.eulerAngles;
            NewRotate.z += 1;
            transform.eulerAngles = NewRotate;
            yield return null;
        }
    }
}
