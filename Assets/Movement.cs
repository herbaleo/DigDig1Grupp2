using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody2D rbody;
    public float moveSpeed;
    public float horizontalMovement;
    public float jumpHeight = 6;

    void Start()
    {
        
    }

 
    void Update()
    {

        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rbody.velocity.y);
        horizontalMovement = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
        }
        

        

    }
}
