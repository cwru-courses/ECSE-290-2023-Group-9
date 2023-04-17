using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 3.5f; // adjust this to change the speed of movement
    private Animator anim;

    private SpriteRenderer sprite;

    private float dirX = 0f;

    //2D Point and Click Attempt!
    //private Vector2 followSpot;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();

        //followSpot = transform.position; // follows the mouse click
    }

    // Update is called once per frame
    public void HandleUpdate()
    {
        //var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //if(Input.GetMouseButtonDown(0))
        //{
            //followSpot = new Vector2(mousePosition.x, transform.position.y);
        //}
        //transform.position = Vector2.MoveTowards(transform.position, followSpot, Time.deltaTime * speed);
        dirX = Input.GetAxisRaw("Horizontal"); // get horizontal input from arrow keys
        Vector3 position = transform.position; // get current position of the sprite

        // adjust x position based on horizontal input and speed
        position.x += dirX * speed * Time.deltaTime;

        // set the sprite's new position
        transform.position = position;

        UpdateAnimation();
    }

    private void UpdateAnimation()
    {
        if (dirX > 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = true;
        }
        else
        {
            anim.SetBool("running", false);
        }
    }


}
