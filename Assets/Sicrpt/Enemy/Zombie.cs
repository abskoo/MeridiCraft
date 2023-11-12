using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public Transform start, end;
    public float speed;
    private Vector3 nextPos;
    //public GameObject Scale_;

    public Animator anim;
    Rigidbody2D rb;

    
    
    void Start()
    {
        speed = GetComponent<EnemyToyal>().MoveSpeed;
        nextPos = start.position;
        //Scale_.transform.localScale = new Vector3(1f, 1f, 1f);
       transform.localScale = new Vector3(0.093291f, 0.093291f, 1f);
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == start.position)
        {
            nextPos = end.position;
            transform.localScale = new Vector3(-0.093291f, 0.093291f, 1f);
            //Scale_.transform.localScale = new Vector3(-1f, 1f, 1f);

        }
        if (transform.position == end.position)
        {
            nextPos = start.position;
            //Scale_.transform.localScale = new Vector3(1f, 1f, 1f);
            transform.localScale = new Vector3(0.093291f, 0.093291f, 1f);
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);

        if (GetComponent<EnemyToyal>().currenHealth <= 0)
        {
            speed = 0;

            anim.SetTrigger("idle");

            Invoke("afterone", 1f);
            Invoke("DesGameOjk", 2f);
                
            

            
        }


    }
    
    //public void setanim()
    //{
    //    if(GetComponent<EnemyToyal>().currenHealth <= 0)
    //    {
    //        speed = 0;

    //        anim.SetTrigger("idle");
    //        anim.SetTrigger("Death");
    //        Invoke("DesGameOjk", 1f);
    //    }
    //}
    public void DesGameOjk()
    {

        Destroy(gameObject);
    }
    public void afterone()
    {
        anim.SetTrigger("Death");
    }
   
    

}
