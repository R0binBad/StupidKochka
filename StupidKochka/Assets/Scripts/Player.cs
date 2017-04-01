using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb2d;
    public float jumpPower;
    public bool groundCheck;
   
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }


    void Update()
    {
         groundCheck = true;
    }

   
     public void Jump(bool isJump)
    {
        isJump = groundCheck;

        if (groundCheck)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpPower);
        }

    }

    


}

