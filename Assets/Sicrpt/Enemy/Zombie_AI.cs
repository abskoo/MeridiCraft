using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_AI : MonoBehaviour
{
    public GameObject Detect;
    private Rigidbody2D rb;
    public bool follow;
    private float MoveSpeed;
    public GameObject RangeObiect;
    public Vector3 Range;
    public Vector3 NewR;
    public Vector3 InitialR;
    public float RangrTOattack;
    public float InitialTimer;
    public float timer;
    public AudioSource sound;
    

    public GameObject DamageBox;
    public Animator anim;

    public bool CanAttack;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        MoveSpeed = GetComponent<EnemyToyal>().MoveSpeed;
        InitialR = Range;
        timer = 0;
        anim = GetComponent<Animator>();
        RangeObiect.GetComponent<BoxCollider2D>().size = Range;

    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (follow)
        {
            if (transform.position.x < Detect.transform.position.x - RangrTOattack)
            {
                rb.velocity = new Vector3(MoveSpeed, rb.velocity.y, 0f);
                transform.localScale = new Vector3(-0.09649365f, 0.09649365f, 0f);

                CanAttack = false;
                anim.SetBool("Run", true);
                
            }
            else if (transform.position.x >= Detect.transform.position.x + RangrTOattack)
            {
                rb.velocity = new Vector3(-MoveSpeed, rb.velocity.y, 0f);
                transform.localScale = new Vector3(0.09649365f, 0.09649365f, 0f);

                CanAttack = false;
                anim.SetBool("Run", true);
               
            }

            else
            {
                CanAttack = true;
                if (timer <= 0)
                {
                    CanAttack = false;
                    timer = InitialTimer;
                }
                else
                {
                    anim.SetBool("Run", false);

                }
               
                

            }
        }



            if (GetComponent<EnemyToyal>().currenHealth <= 0)
            {
                MoveSpeed = 0;
                rb.constraints = RigidbodyConstraints2D.FreezePositionX;
                Invoke("afterone", 1f);
                Invoke("DesGameOjk", 3f);
             }
        

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, Range);

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position,NewR);

        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(RangrTOattack,3f,0f));


    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(!follow)
            {
                follow = true;
                Range = NewR;
                RangeObiect.GetComponent<BoxCollider2D>().size = Range;
                rb.constraints &= ~RigidbodyConstraints2D.FreezePositionX;
                sound.Play();
                sound.loop = true;

            }
            else
                sound.loop = false;
        }
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            if (follow)
            {
                follow = false;
                Range = InitialR;
                RangeObiect.GetComponent<BoxCollider2D>().size = Range;
                anim.SetBool("Run", false);
                

                rb.constraints = RigidbodyConstraints2D.FreezePositionX;
                
                
            }
        }
    }

        public void DesGameOjk()
        {

            Destroy(gameObject);
        }
        public void afterone()
        {
            anim.SetTrigger("Death");
        }


    }
