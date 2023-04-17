using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public DialogManager dialogManager;
    public string[] objectLines;

    // public Sprite sprite;  
    // public Sprite highlightSprite; 
    private static bool canClick;

    private Animator anim;
    private SpriteRenderer sprite;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        canClick = true; 
    }

    // // Update is called once per frame
    // void Update()
    // {
    //     // if(anim.)
    // }

    private void OnMouseEnter()
    {
        if (canClick) { 
            anim.SetBool("hovering", true);
            Debug.Log("hovering");
            // Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto); 
            // transform.GetComponent<SpriteRenderer>().sprite = highlightSprite;
            // Debug.Log("hovering over moon");
        } // change the mouse icon to the specified texture when the mouse enters the object
    }

    private void OnMouseExit()
    {
        if (canClick){ 
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
            anim.SetBool("hovering", false);    
        }// reset the mouse icon to the default when the mouse exits the object
        // transform.GetComponent<SpriteRenderer>().sprite = sprite; 
        
    }

    private void OnMouseDown()
    {
        if (canClick)
        {
            //canClick = false; 
            Debug.Log("Clicked on " + gameObject.name);
            dialogManager.ShowDialog(objectLines);
            // Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
            //StartCoroutine(waitForText());
        }// print a message to the console when the user clicks on the object

    }

    public static void SetClickTrue()
    {
        canClick=true;
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
