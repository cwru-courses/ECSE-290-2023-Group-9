using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonCupHintCount : MonoBehaviour
{
    public static int pistonCupHintHit;
    public GameObject hint1;
    public GameObject hint2;
    public GameObject hint1_Destination;
    public GameObject hint2_Destination;

    private bool stop1;
    private bool stop2;

    // Start is called before the first frame update
    void Start()
    {
        pistonCupHintHit = 0;
        stop1 = false;
        stop2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (pistonCupHintHit == 1 && stop1 == false)
        {
            StartCoroutine(HintOneToFront());
        }

        if (pistonCupHintHit == 2 && stop2 == false)
        {
            StartCoroutine(HintTwoToFront());
        }
    }

    IEnumerator HintOneToFront()
    {
        hint1.gameObject.transform.position = hint1_Destination.gameObject.transform.position;
        stop1 = true;
        yield return null;

    }

    IEnumerator HintTwoToFront()
    {
        hint2.gameObject.transform.position = hint2_Destination.gameObject.transform.position;
        stop2 = true;
        yield return null;

    }
}
