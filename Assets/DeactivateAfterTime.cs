using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class DeactivateAfterTime : MonoBehaviour
{
    public float deactivateTime = 4f; // time in seconds before object is deactivated

    void Start()
    {
        StartCoroutine(DeactivateAfterTimeCoroutine());
    }

    IEnumerator DeactivateAfterTimeCoroutine()
    {
        yield return new WaitForSeconds(deactivateTime);
        gameObject.SetActive(false);
    }
}