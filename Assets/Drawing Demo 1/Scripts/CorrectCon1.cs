using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectCon1 : MonoBehaviour
{
    private BoxCollider2D part;
    // Start is called before the first frame update
    void Start()
    {
        part = GetComponent<BoxCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
            //if (hit.collider.transform != null && part.transform != null && hit.collider.transform == part.transform) 
            if (hit != false)
            {
                if (hit.collider.transform == part.transform)
                {
                    StartCoroutine(GotHit());
                }
            }
        }

    }



    IEnumerator GotHit()
    {
        part.enabled = false;
        CountingHits.numHitCon1 += 1;
        // Debug.Log(numHit);
        //part.enabled = false;
        //Destroy(gameObject);
        yield return null;
        //yield return new WaitForSeconds(.1f);
    }
}
