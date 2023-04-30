using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 3.5f; // adjust this to change the speed of movement
    private Animator anim;

    private SpriteRenderer sprite;

    private float dirX = 0f;


    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();

        //followSpot = transform.position; // follows the mouse click
    }

    // Update is called once per frame
    public void Update()
    {
        //var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //if(Input.GetMouseButtonDown(0))
        //{
        //followSpot = new Vector2(mousePosition.x, transform.position.y);
        //}
        //transform.position = Vector2.MoveTowards(transform.position, followSpot, Time.deltaTime * speed);

        if (!MoveCamera.inNotebook)
        {
            dirX = Input.GetAxisRaw("Horizontal"); // get horizontal input from arrow keys

            if(transform.position.x < -6.65 && dirX < 0)
            {
            } else if (transform.position.x > 25.3 && dirX > 0)
            {
            } else
            {
                Vector3 position = transform.position; // get current position of the sprite

                // adjust x position based on horizontal input and speed
                position.x += dirX * speed * Time.deltaTime;

                // set the sprite's new position
                transform.position = position;

                UpdateAnimation();
            }

            //Vector3 position = transform.position; // get current position of the sprite

            // adjust x position based on horizontal input and speed
           // position.x += dirX * speed * Time.deltaTime;

            // set the sprite's new position
            //transform.position = position;

            //UpdateAnimation();
        }
    }

    private void UpdateAnimation()
    {
        if (dirX > 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = false;
            audioSource.enabled = true;
        }
        else if (dirX < 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = true;
            audioSource.enabled = true;
        }
        else
        {
            anim.SetBool("running", false);
            audioSource.enabled = false;
        }
    }


}
