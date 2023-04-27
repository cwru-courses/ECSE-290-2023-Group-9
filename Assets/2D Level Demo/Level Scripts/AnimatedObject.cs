using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedObject : MonoBehaviour
{
    public DialogManager dialogManager;
    public string[] dialogLines;
    private static bool canClick;

    private SpriteRenderer sprite;
    private Animator anim;

    //[SerializeField] private BoxCollider2D box;

    // Start is called before the first frame update
    void Start()
    {
        canClick = false; 
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        
    }

    private void OnMouseEnter()
    {
        Debug.Log("is hovering");
        anim.SetBool("playAnimation", true);
    }

    private void OnMouseExit()
    {
        // transform.GetComponent<SpriteRenderer>().sprite = sprite; 
        anim.SetBool("playAnimation", false);
        
    }

    private void OnMouseDown()
    {
        // if (canClick)
        // {
        //canClick = false; 
        // Debug.Log("Clicked on " + gameObject.name);
        //dialogManager.ShowDialog(dialogLines);
        // anim.SetBool("playAnimation", false);
        // Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        // StartCoroutine(waitForText());
        //}// print a message to the console when the user clicks on the object
        if (!DialogManager.isActive) 
        {
            Debug.Log("Clicked on " + gameObject.name);
            dialogManager.ShowDialog(dialogLines);
        }

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
