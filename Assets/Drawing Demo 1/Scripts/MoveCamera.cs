using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private Vector3 CameraPosition;
    private bool hasRun = true;
    public bool inNotebook = true;

    // Start is called before the first frame update
    void Start()
    {
        CameraPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (inNotebook && Input.GetKey(KeyCode.RightArrow) && hasRun == true){
            StartCoroutine(TurnPageRight());
        }

        if (inNotebook && Input.GetKey(KeyCode.LeftArrow) && hasRun == true)
        {
            StartCoroutine(TurnPageLeft());
        }


    }

    IEnumerator TurnPageRight()
    {
        hasRun = false;
        CameraPosition.x += 20;
        this.transform.position = CameraPosition;
        yield return new  WaitForSeconds(.5f);
        hasRun = true;

    }

    IEnumerator TurnPageLeft()
    {
        hasRun = false;
        CameraPosition.x -= 20;
        this.transform.position = CameraPosition;
        yield return new WaitForSeconds(.5f);
        hasRun = true;

    }
}
