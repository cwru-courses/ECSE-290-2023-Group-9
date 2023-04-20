using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartHint : MonoBehaviour
{
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
                    StartCoroutine(HintHit());
                }
            }
        }

    }

    IEnumerator HintHit()
    {
        HeartHintCount.heartCupHintHit += 1;
        Destroy(gameObject);
        yield return null;
    }
}
