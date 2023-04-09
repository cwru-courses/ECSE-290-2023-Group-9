using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountingHits : MonoBehaviour
{
    public static int numHit;

    // Start is called before the first frame update
    void Start()
    {
        numHit = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (numHit == 6)
        {
            StartCoroutine(GotThemAll());
        }
    }

    IEnumerator GotThemAll()
    {
        Debug.Log("You Did It :)");
        numHit = 0;
        yield return null;
    }

    IEnumerator GotHit()
    {
        numHit += 1;
        Debug.Log(numHit);
        Destroy(gameObject);
        yield return new WaitForSeconds(.1f);
    }

}
