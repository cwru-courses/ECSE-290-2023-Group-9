using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountingHits : MonoBehaviour
{
    public static int numHit;
    public static int numHitCon1;
    public static int numHitCon2;
    public static int numHitCon3;
    public static int badHit1;
    public static int badHit3;
    public static int badHit2;


    //TODELETE eventually...
    //you win pop up for game demo

    [SerializeField] private GameObject youWinTexts;
    RectTransform youWinText;
    public BoxCollider2D[] reactivateTime;
    // Start is called before the first frame update
    void Start()
    {
        reactivateTime = GetComponentsInChildren<BoxCollider2D>();
        numHit = 0;

        //TODELETE eventually...
        //you win pop up
        //youWinTexts = GameObject.Find("uwuTxt");
        youWinTexts.SetActive(false);
        youWinText = youWinTexts.GetComponent<RectTransform>();
    }


    /*
    // Update is called once per frame
    void Update()
    {
        if (numHitCon1 == 23)
        {
            StartCoroutine(GotThemAll());
            //StartCoroutine(Win());
        }

      
    }
    

    IEnumerator GotThemAll()
    {
        Debug.Log("You Did It :)");
        numHitCon1 = 0;
        yield return null;
    }
    */

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

     public void EnableChildComponents()
    {
        foreach (BoxCollider2D col in reactivateTime)
        {
            col.enabled = true;
        }
        numHitCon1 = 0;
        numHitCon2 = 0;
        numHitCon3 = 0;
        badHit1 = 0;
        badHit2 = 0;
        badHit3 = 0;
      
    }

}
