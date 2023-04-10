using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPage : MonoBehaviour
{
    public static bool validDraw = false;
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
            if (hit.collider != null) //&& hit.collider.transform.name == "RightPage")
            {

                validDraw = true;
                // raycast hit this gameobject
                //Debug.Log("Valid Drawing Area"+validDraw);
            }
            else
            {
                validDraw = false;
                //Debug.Log("Invalid Drawing Area"+validDraw);
            }

            // if (Physics.Raycast(ray, out hit))
            // {
            //if (hit.transform.name == "DrawingArea1" || hit.transform.name == "Square")
            // { print("My object is clicked by mouse"); }
            //}
        }
    }
}
