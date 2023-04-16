using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 3.5f; // adjust this to change the speed of movement
    private Animator anim;

    private float dirX = 0f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
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
        }
        else if (dirX < 0f)
        {
            anim.SetBool("running", true);
        }
        else
        {
            anim.SetBool("running", false);
        }
    }


}
