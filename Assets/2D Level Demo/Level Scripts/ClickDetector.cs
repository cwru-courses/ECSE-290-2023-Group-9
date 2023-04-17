using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    public Texture2D cursorTexture; // set this in the inspector to the texture you want to use as the mouse icon

    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    //void Update()
    //{

    //}
    
    private void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto); // change the mouse icon to the specified texture when the mouse enters the object
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto); // reset the mouse icon to the default when the mouse exits the object
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked on " + gameObject.name); // print a message to the console when the user clicks on the object
    }
    
    
}
