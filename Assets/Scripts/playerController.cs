using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpSpeed;
    private Rigidbody2D myRigidBody;

    public Transform groundCheck;
    public float groundCheckRadius; //Radius of groundcheck
    public LayerMask whatIsGround; //what layer can the player jump
    public bool isGrounded; //Is the player grounded


    // Use this for initialization
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);


        //Move Right 

        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            myRigidBody.velocity = new Vector2(moveSpeed, myRigidBody.velocity.y);
            transform.localScale = new Vector2(1f, 1f);

            //Move Left

        }
        else if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            myRigidBody.velocity = new Vector2(-moveSpeed, myRigidBody.velocity.y);
            transform.localScale = new Vector2(-1f, 1f);
        }
        //No sliding 
        else
        {
            myRigidBody.velocity = new Vector2(0f, myRigidBody.velocity.y);


        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, jumpSpeed);
        }
    }
}


