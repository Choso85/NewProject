using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float lifetime = 5f;
    void Start()
    {
        StartCoroutine(DestroyAfterTime());
    }
    IEnumerator DestroyAfterTime()
    {
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }
}
