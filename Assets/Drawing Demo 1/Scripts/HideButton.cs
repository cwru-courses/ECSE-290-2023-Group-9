using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideButton : MonoBehaviour
{

    public GameObject openScene;
    public GameObject openFar;
    public GameObject closeScene;
    public GameObject closeFar;
    public GameObject checkScene;
    public GameObject checkFar;
    public GameObject clearScene;
    public GameObject clearFar;

    public GameObject openButton;
    public GameObject closeButton;
    public GameObject checkButton;
    public GameObject clearButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenNotebook()
    {
        openButton.gameObject.transform.position = openFar.gameObject.transform.position;
        closeButton.gameObject.transform.position = closeScene.gameObject.transform.position;
        checkButton.gameObject.transform.position = checkScene.gameObject.transform.position;
        clearButton.gameObject.transform.position = clearScene.gameObject.transform.position;

    }


    public void CloseNotebook()
    {

        openButton.gameObject.transform.position = openScene.gameObject.transform.position;
        closeButton.gameObject.transform.position = closeFar.gameObject.transform.position;
        checkButton.gameObject.transform.position = checkFar.gameObject.transform.position;
        clearButton.gameObject.transform.position = clearFar.gameObject.transform.position;

    }


}
