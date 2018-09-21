using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    private int playerHealth = 100;
    public float playerSpeed;
    private Rigidbody2D myRigidBody;

    // Use this for initialization
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            myRigidBody.velocity = new Vector2(playerSpeed, myRigidBody.velocity.y);


        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            myRigidBody.velocity = new Vector2(playerSpeed*-1, myRigidBody.velocity.y);

        }

        if (Input.GetAxisRaw("Vertical") > 0f)
        {
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, playerSpeed);
        }
    }
}


