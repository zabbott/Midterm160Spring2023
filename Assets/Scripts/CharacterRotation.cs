using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    public Coroutine Rotate;
    public GameObject SadAntWithBindle;

    void Start()
    {
        
    }

    void Update()
    {
        
        if(Input.GetKey(KeyCode.Space))
        {

            Rotate = StartCoroutine(RotateAnt());

        }

    }

    public IEnumerator RotateAnt()
    {

        while (Input.GetKey(KeyCode.Space))
        {

            SadAntWithBindle.transform.eulerAngles += new Vector3(0, 0, 0.5f);
            yield return null;

        }

    }
}
