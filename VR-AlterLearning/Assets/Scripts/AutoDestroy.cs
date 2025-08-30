using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    [SerializeField]
    float timeDestroyed = 2;

    void Start()
    {
        StartCoroutine(DestroyGameobject());
    }

    IEnumerator DestroyGameobject()
    {
        yield return new WaitForSeconds(timeDestroyed);
        Destroy(this.gameObject);
    }
}
