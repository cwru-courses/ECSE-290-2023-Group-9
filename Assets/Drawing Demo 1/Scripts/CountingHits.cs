using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountingHits : MonoBehaviour
{
    public static int numHit;

    //TODELETE eventually...
    //you win pop up for game demo

    [SerializeField] private GameObject youWinTexts;
    RectTransform youWinText;

    // Start is called before the first frame update
    void Start()
    {
        numHit = 0;

        //TODELETE eventually...
        //you win pop up
        //youWinTexts = GameObject.Find("uwuTxt");
        youWinTexts.SetActive(false);
        youWinText = youWinTexts.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (numHit == 6)
        {
            StartCoroutine(GotThemAll());
            StartCoroutine(Win());
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

    IEnumerator Win()
    {
        youWinTexts.SetActive(true);
        yield return new WaitForSeconds(2f);
        youWinTexts.SetActive(false);
    }

}
