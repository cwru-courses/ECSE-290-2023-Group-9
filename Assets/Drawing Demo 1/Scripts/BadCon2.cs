using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadCon2 : MonoBehaviour
{
    BoxCollider2D part;
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
            if (hit.collider.transform == this.transform)
            {
                StartCoroutine(GotHit());
            }

        }

    }



    IEnumerator GotHit()
    {
        CountingHits.badHit2 += 1;
        // Debug.Log(numHit);
        //part.enabled = false;
        //Destroy(gameObject);
        yield return null;
        //yield return new WaitForSeconds(.1f);
    }
}


