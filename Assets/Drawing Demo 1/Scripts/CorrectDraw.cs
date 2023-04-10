using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectDraw : MonoBehaviour
{

    //public int numHit;


    // Start is called before the first frame update
    void Start()
    {
        //numHit = 0;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
            if (hit.collider.transform == this.transform)
            { 
                StartCoroutine(GotHit());
            }

        }

        /*
        if (numHit == 5)
        {
            StartCoroutine(GotThemAll());
        }
        */
    }
        


IEnumerator GotHit()
{
        CountingHits.numHit += 1;
   // Debug.Log(numHit);
    Destroy(gameObject);
    yield return new WaitForSeconds(.1f);
}


    /*
IEnumerator GotThemAll()
{
    Debug.Log("You Did It :)");
    numHit = 0;
    yield return null;
}
    */
    


  
}