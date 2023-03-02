using System.Collections;
using UnityEngine;


public class CharacterRotation : MonoBehaviour
{
    public GameObject Meme;
    public Coroutine Spin;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Spin = StartCoroutine(RotateSprite());
        if (Input.GetKeyUp(KeyCode.Space))
        {
            StopAllCoroutines();
            Spin = null;
        }
    }
    public IEnumerator RotateSprite()
    {
        float zChange = 0f;
        while (true)
        {
            Meme.transform.eulerAngles = new Vector3(0f, 0f, zChange);
            zChange += 1f;
            yield return null;
        }
    }
}
