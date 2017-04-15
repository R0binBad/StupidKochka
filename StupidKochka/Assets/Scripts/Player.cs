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
    public bool isSit ;
    public bool isLive;
    public int deadCounter;
    public AudioClip jump;
    public AudioClip dead;
    void Start()
    {
       rb2d = GetComponent<Rigidbody2D>();
       animator = GetComponent<Animator>();
       sprite = GetComponent<SpriteRenderer>();
       isLive = true;
       deadCounter =0;//чтобы потесить
}

    void Update()
    {
        if (groundCheck)
        {
            if(!isSit)
            State = CharState.Run;
            
        }

        if (isSit) State = CharState.Sit;

        CheckGround();
        if (isLive == false && deadCounter < 8)
        {
            State = CharState.Dead;
            deadCounter++;
        }
        if (deadCounter >= 8)
        {
            deadCounter = 0;
            isLive = true; 
        }
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
            gameObject.GetComponent<AudioSource>().clip = jump;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }

    public void Sit(bool sit)
    {
        
        isSit = true;
              
    }

    public void Up(bool up)
    {

        isSit = false;

    }

    private void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 2F);

        //groundCheck = colliders.Length > 1;
        bool tempCheck = false;  
        if (colliders.Length > 1)
        {
            foreach (Collider2D collid in colliders)
            {
                if (collid.transform.tag == "ground") tempCheck = true;
            }
            groundCheck = tempCheck;//даже не пытайся понять хач ебаный
        }
        else
            groundCheck = false;

        if (!groundCheck) State = CharState.Jump;
    }
}

 public enum CharState
    {
        Run,
        Jump,
        Sit,
        Dead
    }


