using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public GameObject professorMan;

    //public GameObject transportStart;
    public GameObject transportDestination;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
            if (hit != false)
            {
                if (hit.collider.transform == this.transform)
                {
                    StartCoroutine(StairsMoment());
                }
            }
        }
    }

    IEnumerator StairsMoment()
    {
        // professorman animation start
        // wait for however long animation
        // Black Screen?

        professorMan.gameObject.transform.position = transportDestination.gameObject.transform.position;
        //Black Screen Disappear
        yield return null;
    }
}
