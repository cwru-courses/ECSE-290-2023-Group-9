using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private Vector3 CameraPosition;
    private bool hasRun = true;
    public static bool inNotebook = false;

    // Start is called before the first frame update
    void Start()
    {
        CameraPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (inNotebook && Input.GetKey(KeyCode.P) && hasRun == true
            // && whatever the x coordinate bound is
            ){
            StartCoroutine(TurnPageRight());
        }

        if (inNotebook && Input.GetKey(KeyCode.O) && hasRun == true)
        {
            StartCoroutine(TurnPageLeft());
        }


    }

    IEnumerator TurnPageRight()
    {
        CameraPosition = this.transform.position;
        hasRun = false;
        CameraPosition.x += 13;
        this.transform.position = CameraPosition;
        yield return new  WaitForSeconds(.5f);
        hasRun = true;

    }

    IEnumerator TurnPageLeft()
    {
        CameraPosition = this.transform.position;
        hasRun = false;
        CameraPosition.x -= 13;
        this.transform.position = CameraPosition;
        yield return new WaitForSeconds(.5f);
        hasRun = true;

    }
}
