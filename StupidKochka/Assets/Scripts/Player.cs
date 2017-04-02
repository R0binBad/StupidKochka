using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb2d;
    public float jumpPower;
    public bool groundCheck;
    private Animator animator;
    private SpriteRenderer sprite;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
       animator = GetComponent<Animator>();
       sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (groundCheck) State = CharState.Run;
        CheckGround();
    }

    private CharState State
    {
        get { return (CharState)animator.GetInteger("State"); }
        set { animator.SetInteger("State", (int)value); }
    }

    public void Jump(bool isJump)
    {
        isJump = groundCheck;

        if (groundCheck)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpPower);
        }
    }

    private void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 2F);

        groundCheck = colliders.Length > 1;

        if (!groundCheck) State = CharState.Jump;
    }

   
}

 public enum CharState
    {
        Run,
        Jump,
        Sit
    }


