using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScript : MonoBehaviour
{

    public static bool drawing_1_Complete = false;
    public static bool drawing_2_Complete = false;
    public static bool drawing_3_Complete = false;


    public void CheckDrawing1()
    {

        if (CountingHits.numHitCon1 == 0 && CountingHits.badHit1 == 0)
        {
            
        }
        else
        {
            if (CountingHits.numHitCon1 == 23 && CountingHits.badHit1 < 1)
            {
                Debug.Log("Constellation 1 is right");
                drawing_1_Complete = true;
            }

            if (CountingHits.badHit1 > 0)
            {
                Debug.Log("Are you sure you're drawing constellation 1?");
            }

            if (CountingHits.numHitCon1 < 23 && CountingHits.badHit1 < 1)
            {
                Debug.Log("Missing a few boxes");
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
                Debug.Log("Constellation 2 is right");
                drawing_2_Complete = true;
            }

            if (CountingHits.badHit2 > 0)
            {
                Debug.Log("Are you sure you're drawing constellation 2?");
            }

            if (CountingHits.numHitCon2 < 27 && CountingHits.badHit2 < 1)
            {
                Debug.Log("Missing a few boxes");
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
                Debug.Log("Constellation 3 is right");
                drawing_3_Complete = true;
              //  SceneController.setDrawn();
            }

            if (CountingHits.badHit3 > 0)
            {
                Debug.Log("Are you sure you're drawing constellation 3?");
            }

            if (CountingHits.numHitCon3 < 24 && CountingHits.badHit3 < 1)
            {
                Debug.Log("Missing a few boxes");
            }
        }


    }

}
