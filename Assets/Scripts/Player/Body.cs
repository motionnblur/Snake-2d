using System.Collections;
using UnityEngine;

public class Body : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(openCollider());
    }

    IEnumerator openCollider()
    {
        yield return new WaitForSeconds(0.5f);
        GetComponent<BoxCollider2D>().enabled = true;
    }
}
