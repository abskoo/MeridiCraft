using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Enemy : MonoBehaviour
{
    public GameObject player;
    public GameObject Damage;

    public GameObject HealthEnemy;
    public int Max_Health = 10;
    public int Currunt_Health;

    public float TimeDeath;
    public Animator anim;

    
    
    void Start()
    {
        HealthEnemy.GetComponent<Slider>().maxValue = Max_Health;
        Currunt_Health = Max_Health;
        anim = GetComponent<Animator>();
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D Other)
    {
        if (Other.tag == "Player")
        {
            player.GetComponent<Player_Move>().currunt_Health = player.GetComponent<Player_Move>().currunt_Health - 1;

            Damage.GetComponent<Health>().HealthUpdate(player.GetComponent<Player_Move>().currunt_Health);
            

        }

    }
    public void DestroyEnemy()
    {
        anim.SetTrigger("Death"); 
        Invoke("DestroyE", 1f);


    }
    public void DestroyE()
    {
        Destroy(gameObject);

    }





}
