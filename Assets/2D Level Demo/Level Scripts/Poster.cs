using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster : MonoBehaviour
{
    public Texture2D cursorTexture;
    private static bool canClick;
    private bool clicked;

    public DialogManager dialogManager;
    public string[] DoorZerolines;

    [SerializeField] private GameObject posterHints;
    RectTransform posterHint;
    // Start is called before the first frame update
    void Start()
    {
        canClick = false;
  
        posterHints.SetActive(false);
        posterHint = posterHints.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter()
    {
        if (canClick) { Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto); } // change the mouse icon to the specified texture when the mouse enters the object
    }

    private void OnMouseExit()
    {
        if (canClick) { Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto); }// reset the mouse icon to the default when the mouse exits the object
    }

    private void OnMouseDown()
    {
        if (canClick)
        {

            //canClick = false; 
            Debug.Log("Clicked on " + gameObject.name);
            posterHints.SetActive(true);
            dialogManager.ShowDialog(DoorZerolines);
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
            //StartCoroutine(waitForText());
        }// print a message to the console when the user clicks on the object

    }

    public static void SetClickTrue()
    {
        canClick = true;
    }

    public static void SetClickFalse()
    {
        canClick = false;
    }


    IEnumerator waitForText()
    {
        yield return new WaitForSeconds(7f);
        SetClickTrue();
    }

}
