using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorZero : MonoBehaviour
{
    public Texture2D cursorTexture;
    private static bool canClick;

    public DialogManager dialogManager;
    public string[] DoorZerolines;

    // Start is called before the first frame update
    void Start()
    {
        canClick = false;
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
        if (canClick){ Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);}// reset the mouse icon to the default when the mouse exits the object
    }

    private void OnMouseDown()
    {
        if (canClick) { Debug.Log("Clicked on " + gameObject.name); }// print a message to the console when the user clicks on the object
        dialogManager.ShowDialog(DoorZerolines);
    }

    public static void SetClick()
    {
        canClick=true;
    }

}
