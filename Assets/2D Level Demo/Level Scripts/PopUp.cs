using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public float popUpDistance = 0.5f; // the distance the item pops up when clicked

    private bool isPoppedUp = false; // variable to keep track of whether the item is popped up or not
    private Vector3 originalScale; // the original position of the item

    void Start()
    {
        originalScale = transform.localScale; // store the original position of the item
    }

    void Update()
    {
       if (!isPoppedUp)
        {
           transform.localScale = originalScale;
        }
    }

    void OnMouseDown()
    {
        if (!isPoppedUp)
        {
            transform.localScale *= popUpDistance; // pop up the item
            isPoppedUp = true;
            //StartCoroutine(goBack());
            isPoppedUp=false;
        }
        else
        {
            transform.localScale = originalScale; // return the item to its original position
            isPoppedUp = false;
        }
    }

    IEnumerator goBack()
    {
        yield return new WaitForSeconds(2f);

    }
}



