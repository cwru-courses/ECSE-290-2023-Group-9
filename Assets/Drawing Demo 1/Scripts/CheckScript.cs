using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CheckScript : MonoBehaviour
{
    public PlayableDirector director3;
    public static bool drawing_1_Complete = false;
    public static bool drawing_2_Complete = false;
    public static bool drawing_3_Complete = false;
    private bool firstTime3 = true;
    private bool firstTime2 = true;
    private bool firstTime1 = true;

    DrawManager drawDelete;

    [Header("wrongAudio")]
    private AudioClip wrongClip; //unserialized field
    [SerializeField] private AudioSource audioSourceW;

    [Header("rightAudio")]
    private AudioClip rightClip; //unserialized field
    [SerializeField] private AudioSource audioSourceR;


    private void Start()
    {
        drawDelete = GameObject.FindGameObjectWithTag("Draw Manager").GetComponent<DrawManager>();
        wrongClip = audioSourceW.clip;
        rightClip = audioSourceR.clip;
    }


    public void CheckDrawing1()
    {

        if (CountingHits.numHitCon1 == 0 && CountingHits.badHit1 == 0)
        {
            
        }
        else
        {
            if (CountingHits.numHitCon1 == 23 && CountingHits.badHit1 < 1)
            {
                audioSourceR.Play();
                Debug.Log("Constellation 1 is right");
                drawing_1_Complete = true;
                StartCoroutine(FeatherFadeIn());
            }

            if (CountingHits.badHit1 > 0)
            {
                Debug.Log("Are you sure you're drawing constellation 1?");
                audioSourceW.Play();
                Vector3 mousePos = Input.mousePosition;
                Debug.Log("Mouse position: " + mousePos);
            }

            if (CountingHits.numHitCon1 < 23 && CountingHits.badHit1 < 1)
            {
                Debug.Log("Missing a few boxes");
                audioSourceW.Play();
            }
        }


    }

    public void CheckDrawing2()
    {
       // Debug.Log(CountingHits.numHitCon2);
        if (CountingHits.numHitCon2 == 0 && CountingHits.badHit2 == 0)
        {

        }
        else
        {
            if (CountingHits.numHitCon2 == 27 && CountingHits.badHit2 < 1)
            {
                audioSourceR.Play();
                Debug.Log("Constellation 2 is right");
                drawing_2_Complete = true;
                StartCoroutine(CupFadeIn());
            }

            if (CountingHits.badHit2 > 0)
            {
                Debug.Log("Are you sure you're drawing constellation 2?");
                audioSourceW.Play();
            }

            if (CountingHits.numHitCon2 < 27 && CountingHits.badHit2 < 1)
            {
                Debug.Log("Missing a few boxes");
                audioSourceW.Play();
            }
        }


    }

    public void CheckDrawing3()
    {
        //Debug.Log(CountingHits.numHitCon3);

        if (CountingHits.numHitCon3 == 0 && CountingHits.badHit3 == 0)
        {

        }
        else
        {
            if (CountingHits.numHitCon3 == 24 && CountingHits.badHit3 < 1)
            {
                audioSourceR.Play();
                Debug.Log("Constellation 3 is right");
                drawing_3_Complete = true;
                StartCoroutine(HeartFadeIn());
              //  SceneController.setDrawn();
            }

            if (CountingHits.badHit3 > 0)
            {
                Debug.Log("Are you sure you're drawing constellation 3?");
                audioSourceW.Play();
            }

            if (CountingHits.numHitCon3 < 24 && CountingHits.badHit3 < 1)
            {
                Debug.Log("Missing a few boxes");
                audioSourceW.Play();
            }
        }


    }



    IEnumerator HeartFadeIn()
    {
        if (firstTime3 == true)
        {
            firstTime3 = false;
            drawDelete.Delete();
            director3.Play();
        }
        yield return null;
    }


    IEnumerator CupFadeIn()
    {
        if (firstTime2 == true)
        {
            firstTime2 = false;
            drawDelete.Delete();
            director3.Play();
        }
        yield return null;
    }

    IEnumerator FeatherFadeIn()
    {
        if (firstTime1 == true)
        {
            firstTime1 = false;
            drawDelete.Delete();
            director3.Play();
        }
        yield return null;
    }

}
