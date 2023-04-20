using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelescopeCheck : MonoBehaviour
{
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
                    StartCoroutine(EndCheck());
                }
            }
        }
    }

    IEnumerator EndCheck()
    {
        if (
            //CheckScript.drawing_1_Complete &&
            CheckScript.drawing_2_Complete &&
            CheckScript.drawing_3_Complete)
        {
            SceneController.setDrawn();
           
        }
        else
        {
            Debug.Log("You seem to be missing a drawing");
        }
        yield return null;
    }
}
