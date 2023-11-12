using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    //public static Player instance;
    Rigidbody2D rb;
    SpriteRenderer sr;
    [SerializeField]
    float speed = 10;
    [SerializeField]
    float Jump = 2f;
    bool Isjump;
    Animator anmi;

    
    public Transform groundcheck;
    public float groundCheckRadius;
    public LayerMask WhatIsGround;
    public bool OnGround;
    public bool CanMove;

    public float invincableTime;
    public float invincableTimer;

    public float attackTime;
    private float attackTimer;

    public GameObject damagebox;

    public float max_health = 3;
    public float currnetHealth;
    public Healthbar healthbar;

    //The Invincable
    public GameObject immunity;

    //Update code Move

    private float horizontalMove;
    private bool MoveRight;
    private bool MoveLeft;
    private bool BoolJump;
    private bool BoolAttack;







    void Start()
    {
        
        Isjump = false;
        BoolJump = false;
        BoolAttack = false;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anmi = GetComponent<Animator>();
        CanMove = true;
        transform.localScale = new Vector3(0.2060078f, 0.2161167f, 1f);
        currnetHealth = max_health;
        healthbar.slider.maxValue = max_health;
        MoveRight = false;
        MoveLeft = false;
        
        //healthbar.GetComponent<Healthbar>().slider.maxValue = max_health;

    }

    
    void Update()
    {
        Movement();

        //Know the ground
        OnGround = Physics2D.OverlapCircle(groundcheck.position, groundCheckRadius, WhatIsGround);
        MoveJump();
        //Code_Jump
        //if (CrossPlatformInputManager.GetButtonDown("Jump") && Isjump == false)
        //{

        //    rb.velocity = new Vector2(0, Jump);
        //    Isjump = true;
        //}
        //else if (Mathf.Abs(rb.velocity.y) < 0.01f)
        //{
        //    Isjump = false;
        //}
        //Code_Flip_And_Move_Animation
        //if (CrossPlatformInputManager.GetAxis("Horizontal") >= 1f)
        //{
        //    //transform.Translate(new Vector3(-1 * speed, 0, 0));
        //    //sr.flipX = true;
        //    anmi.SetBool("Run", true);
        //    transform.localScale = new Vector3(0.2060078f, 0.2161167f, 1f);
        //}
        //else if (CrossPlatformInputManager.GetAxis("Horizontal") <= -1f)
        //{
        //    //transform.Translate(new Vector3(speed, 0, 0));
        //    //sr.flipX = false;
        //    anmi.SetBool("Run", true);
        //    transform.localScale = new Vector3(-0.2060078f, 0.2161167f, 1f);
        //}
        //else
        //{
        //    anmi.SetBool("Run", false);
        //}

        

        
        if(invincableTimer > 0)
        {
          
            invincableTimer -= Time.deltaTime;
        }
        if(invincableTimer <= 0)
        {
            immunity.GetComponent<Theimmunity>().invincable = false;
           
        }

        if(attackTimer > 0)
        {
            attackTimer -= Time.deltaTime;
        }else
        {
            ActivAttack();
            
                
            //if (Input.GetKey(KeyCode.Q))
            //{
            //    if (!OnGround)
            //    {
            //        anmi.SetTrigger("JumpAttack");
            //    }
            //    //else if (Mathf.Abs(rb.velocity.x) > 0 && OnGround)
            //    //{
            //    //    anmi.SetTrigger("RunAttack");
            //    //}
            //    else
            //    {
            //        anmi.SetTrigger("IdleAttack");
            //    }
            //}
        }

  
    }

    public void PointerDownLeft()
    {
        MoveLeft = true;
        anmi.SetBool("Run", true);
        transform.localScale = new Vector3(-0.2060078f, 0.2161167f, 1f);
    }
    public void PointerUPeft()
    {
        MoveLeft = false;
    }
    public void PointerDownRight()
    {
        MoveRight = true;
        anmi.SetBool("Run", true);
        transform.localScale = new Vector3(0.2060078f, 0.2161167f, 1f);
    }
    public void PointerUPRight()
    {
        MoveRight = false;
    }

    void Movement()
    {
        if (MoveLeft)
        {
            horizontalMove = -speed;
        }
        else if (MoveRight)
        {
            horizontalMove = speed;
            
        }
        else
        {
            horizontalMove = 0;
            anmi.SetBool("Run", false);

        }
    }

    public void DownJump()
    {
        BoolJump = true;
       

    }
    public void UPJump()
    {
        BoolJump = false;
        
    }

    void MoveJump()
    {
        if (BoolJump == true && Isjump == false)
        {
            rb.velocity = new Vector2(0, Jump);
            Isjump = true;
        }
        else if(!BoolJump && Mathf.Abs(rb.velocity.y) < 0.01f)
        {
            Isjump = false;
        }
    }

    public void AttackDown()
    {
        BoolAttack = true;
        if(!OnGround)
        {
            anmi.SetTrigger("JumpAttack");

        }
        else
            anmi.SetTrigger("IdleAttack");
    }
    public void AttackUP()
    {
        BoolAttack = false;
    }

    void ActivAttack()
    {
        if (BoolAttack)
        {
            int bb = 1;
            
        }
        else if(!BoolAttack)
        {
            int vv = 1;
        }
        
    }
    private void FixedUpdate()
    {
       // var movement = CrossPlatformInputManager.GetAxis("Horizontal");
        if (CanMove)
        {
            //Code_Move_Plaer
           // rb.velocity = new Vector2(speed * CrossPlatformInputManager.GetAxis("Horizontal"),rb.velocity.y);
            // transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;
            rb.velocity = new Vector2(horizontalMove, rb.velocity.y);






        }

        

    }

 

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundcheck.position, groundCheckRadius);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "PlatForm")
        {
            transform.parent = other.transform;
        }
       

    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag == "PlatForm")
        {
            transform.parent = null;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "MapLimit")
        {
            currnetHealth = 0;
            nagetiveHealth();

            DeathState();
        }
        
        
    }
    public void DeathState()
    {
        GetComponent<Rigidbody2D>().simulated = false;
        CanMove = false;
        anmi.SetTrigger("Death");
    }
    
    public void AttackOn()
    {
        damagebox.SetActive(true);
    }
    public void AttackOff()
    {
        damagebox.SetActive(false);
    }


    //Player_Udate_health
    public void nagetiveHealth()
    {
       
         if (currnetHealth > max_health)
        {
            currnetHealth = max_health;
            
        }
            
        if (currnetHealth < 0)
        {
            currnetHealth = 0;
            
        }
       // healthbar.GetComponent<Healthbar>().setHealth(currnetHealth);
        healthbar.setHealth(currnetHealth);

    }

    public void PostiveHealth()
    {
        
       // healthbar.setHealth(currnetHealth);

    }
  




}

