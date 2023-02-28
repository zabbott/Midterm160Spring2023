using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    public Coroutine CachedRotateRoutine;
    public GameObject MemeImage;
    public float RotateSpeed;
    public Color ColorTwo;
    public Color ColorOne;


    private void Start()
    {
        StartCoroutine(ColorShift());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CachedRotateRoutine = StartCoroutine(RotateRoutine());
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            StopCoroutine(CachedRotateRoutine);
        }
    }

    public IEnumerator RotateRoutine()
    {
        while (true)
        {
            MemeImage.transform.Rotate(Vector3.forward, RotateSpeed);
            yield return null;
        }
    }

    public IEnumerator ColorShift()
    {
        var spr=  MemeImage.GetComponent<SpriteRenderer>();
        spr.color = ColorOne;
        int changeCount = 0;  
        while (changeCount < 10)
        {
            if(spr.color == ColorOne)
            {
                spr.color = ColorTwo; 
            }
            else
            {
                spr.color = ColorOne;
            }
            changeCount++;
            yield return new WaitForSeconds(2);
        }
    }
}
