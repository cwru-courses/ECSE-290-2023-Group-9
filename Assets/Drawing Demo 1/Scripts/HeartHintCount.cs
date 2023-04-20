using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartHintCount : MonoBehaviour
{
    public static int heartCupHintHit;
    public GameObject hint1;
    public GameObject hint2;
    public GameObject hint3;
    public GameObject hint1_Destination;
    public GameObject hint2_Destination;
    public GameObject hint3_Destination;

    private bool stop1;
    private bool stop2;
    private bool stop3;
    // Start is called before the first frame update
    void Start()
    {
        heartCupHintHit = 0;
        stop1 = false;
        stop2 = false;
        stop3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (heartCupHintHit == 1 && stop1 == false)
        {
            StartCoroutine(HintOneToFront());
        }

        if (heartCupHintHit == 2 && stop2 == false)
        {
            StartCoroutine(HintTwoToFront());
        }

        if (heartCupHintHit == 3 && stop3 == false)
        {
            StartCoroutine(HintThreeToFront());
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

    IEnumerator HintThreeToFront()
    {
        hint3.gameObject.transform.position = hint3_Destination.gameObject.transform.position;
        stop2 = true;
        yield return null;

    }
}
