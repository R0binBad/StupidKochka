using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
	public Text distanceText;
	public float distance;
	public float speed;
	public float gravitySoar;
	public float gravityNormal;
	private bool sound;
    void Start()
    {
       rb2d = GetComponent<Rigidbody2D>();
       animator = GetComponent<Animator>();
       sprite = GetComponent<SpriteRenderer>();
       isLive = true;
       deadCounter =0;//чтобы потесить
	   speed = 10;
	   gravitySoar = 5;
	   rb2d.gravityScale = gravityNormal = 10;
	   sound = (PlayerPrefs.GetString("music") == "on"); 
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
	void OnGUI()
	{
		if (isLive == true)
		{//пока жив обновлять
			distance += (Time.deltaTime * speed) / 5;
			distanceText.text = System.Math.Round(distance, 0).ToString() + " м";
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
			if (sound)gameObject.GetComponent<AudioSource>().Play();
			rb2d.gravityScale = gravitySoar;
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

	public void kill()
	{
		isLive = false;
		if (PlayerPrefs.GetFloat ("distance") < distance) 
		{
			PlayerPrefs.SetFloat ("distance", distance);	
		}
	}
	public void releaseJump()
	{
		rb2d.gravityScale = gravityNormal;
	}

}	
 public enum CharState
    {
        Run,
        Jump,
        Sit,
        Dead
    }


