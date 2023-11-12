using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Move : MonoBehaviour
{
    
    Rigidbody2D rb;
    SpriteRenderer sr;

    public float speed;
    public float Jump;
    bool Isjump;
    Animator anim;
    public Transform CheckGround;
    public float Readius;
    public LayerMask WhatIsGround;
    public bool OnGround;

    public GameObject Healthbar;
    public int Max_Health = 10;
    public int currunt_Health;

    public GameObject Box;
    // Start is called before the first frame update
    void Start()
    {
        currunt_Health = Max_Health;
        Isjump = false;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        Healthbar.GetComponent<Slider>().maxValue = Max_Health;
        
    }

    // Update is called once per frame
    void Update()
    {
        OnGround = Physics2D.OverlapCircle(CheckGround.position, Readius,WhatIsGround);
        //Jump_Player
        if (Input.GetButtonDown("Jump") && Isjump == false)
        {

            rb.velocity = new Vector2(0, Jump);
            Isjump = true;

            // anim.SetTrigger("jump");
        }
        else if (Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            Isjump = false;
            //anim.SetBool("jump", false);
        }

        //Flip
        if (Input.GetKey(KeyCode.RightArrow))
        {
            sr.flipX = true;
            anim.SetBool("Run", true);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            sr.flipX = false;
            anim.SetBool("Run", true);
        }else
             anim.SetBool("Run", false);

        anim.SetBool("Jump", OnGround);

        if(Input.GetKey(KeyCode.Q))
        {
            if(!OnGround)
            {
                anim.SetTrigger("JumpAttack");
            }else if(Mathf.Abs(rb.velocity.x) > 0 && OnGround)
            {
                anim.SetTrigger("RunAttack");
            }else
                anim.SetTrigger("IdleAttack");
        }
                

    }
    

    private void FixedUpdate()
    {
        //Move_PLayer
        rb.velocity = new Vector2(speed * Input.GetAxis("Horizontal"), rb.velocity.y);
    }

    public void TakeON()
    {
        Box.SetActive(true);
    }
    public void TakeOf()
    {
        Box.SetActive(false);

    }



}
