using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamagePlayer : MonoBehaviour
{
    public GameObject enemy;
    public GameObject healthEnemy;

    public bool invincable;
    public float invincableTime;
    public float invincableTimer;


    void Start()
    {
        
        
        
    }

    
    void Update()
    {
        if(invincableTimer > 0)
        {
            invincableTimer -= Time.deltaTime;
        }
        else
        {
            invincable = false;
        }
             
        
    }
    private void OnTriggerStay2D(Collider2D Other)
    {
         if (Input.GetKey(KeyCode.Q) && Other.tag == "Enemy")
        {

            if (!invincable)
            {
                
                enemy.GetComponent<Enemy>().Currunt_Health = enemy.GetComponent<Enemy>().Currunt_Health - 1;
                healthEnemy.GetComponent<HealthEnemy>().HealthUpdate(enemy.GetComponent<Enemy>().Currunt_Health);
                invincableTimer = invincableTime;
                invincable = true;

            }
            if(enemy.GetComponent<Enemy>().Currunt_Health <= 0)
            {
                enemy.GetComponent<Enemy>().DestroyEnemy();           
            }
            
            
                


            
        }
    }

    

    
}
