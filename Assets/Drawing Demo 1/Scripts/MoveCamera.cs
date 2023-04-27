using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private Vector3 CameraPosition;
    private bool hasRun = true;
    public static bool inNotebook = false;
    //private static bool first;

    [Header("Page Flip Audio")]
    private AudioClip flipClip; //unserialized field
    [SerializeField] private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        CameraPosition = this.transform.position;
        flipClip = audioSource.clip;
        audioSource.time = 1.05f;
       //first = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (inNotebook && Input.GetKey(KeyCode.P) && hasRun == true
            // && whatever the x coordinate bound is
            ){
            //audioSource.Play();
            StartCoroutine(TurnPageRight());
        }

        if (inNotebook && Input.GetKey(KeyCode.O) && hasRun == true)
        {
            //audioSource.Play();
            StartCoroutine(TurnPageLeft());
        }


    }

    IEnumerator TurnPageRight()
    {
        
        CameraPosition = this.transform.position;
        //Debug.Log(CameraPosition.x);
        if (CameraPosition.x < -280)
        {
            audioSource.Play();
            hasRun = false;
            CameraPosition.x += 13;
            this.transform.position = CameraPosition;
            yield return new WaitForSeconds(.5f);
            hasRun = true;
        }
    }

    IEnumerator TurnPageLeft()
    {
        CameraPosition = this.transform.position;
        //Debug.Log(CameraPosition.x);
        if (CameraPosition.x > -290)
        {
            audioSource.Play();
            hasRun = false;
            CameraPosition.x -= 13;
            this.transform.position = CameraPosition;
            yield return new WaitForSeconds(.5f);
            hasRun = true;
        }
    }
}
