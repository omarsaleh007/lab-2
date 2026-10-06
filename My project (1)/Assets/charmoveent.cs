using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charmoveent : MonoBehaviour
{
    public float moveSpeed;
    public float JumpHeight;
    public KeyCode Spacebar;
    public KeyCode L;
    public KeyCode R;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask WhatIsGround;
    private bool grounded;
    void Start()
    {
        
    }

       
    void Update()
    {

        if (Input.GetKey(L))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        
            if(GetComponent<Rigidbody2D>().velocity.x < 0)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
        
        
        }
        if(Input.GetKeyDown(Spacebar) && grounded)
        {
            Jump();
        }

        if (Input.GetKey(R))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            if(GetComponent<Rigidbody2D>().velocity.x > 0)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
            
        }
    }
    void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
    }
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, WhatIsGround);
    }
}

