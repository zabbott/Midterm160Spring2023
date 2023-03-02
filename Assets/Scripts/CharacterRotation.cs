using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    public GameObject character;
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

    IEnumerator RotateSprite()
    {
        while (Input.GetKey(KeyCode.Space))
        {
            character.transform.Rotate(Vector3.forward);
            yield return null;
        }
    }
}
