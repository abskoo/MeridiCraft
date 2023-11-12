using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyToyal : MonoBehaviour
{
    public static EnemyToyal insert;
    public int MaxHealth;
    public int currenHealth;
    public int Damage;
    public float MoveSpeed;

    public Animator anim;
    public float TimeAnim;

    public bool invinceable;
    public float invincableTime;
    public float invincableTimer;
    public GameObject Player;
    
    // Start is called before the first frame update
    void Start()
    {
        currenHealth = MaxHealth;
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (invincableTimer > 0)
        {
            invincableTimer -= Time.deltaTime;
        }
        else
        {
            invinceable = false;
        }
    }
    public void TakeDamage(int Damage)
    {
        if (!invinceable)
        {
            currenHealth -= Damage;
            if (currenHealth <= 0)
            {

                //anim.SetTrigger("Death");
                //Invoke("DesGameOjk", 1f);
               //yer.GetComponent<Player>().PlayerHealth();
            }
            invincableTime = invincableTimer;
            invinceable = true;
        }
        
     

    }
    //public void DesGameOjk()
    //{
    //     Destroy(gameObject);
    //}


    
}
