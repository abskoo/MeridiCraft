using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZombieAI : MonoBehaviour
{
    public float damage;
    public GameObject player;
    public GameObject immuinty;
    void Start()
    {
        if (GetComponent<EnemyToyal>())

            damage = GetComponent<EnemyToyal>().Damage;
        else if (GetComponentInParent<EnemyToyal>())

            damage = GetComponentInParent<EnemyToyal>().Damage;
        

        

        
    }

    private void OnTriggerStay2D(Collider2D Other)
    {
        if(Other.tag == "Player")
        {
            if(immuinty.GetComponent<Theimmunity>().invincable == false)
            { 
                player.GetComponent<Player>().currnetHealth -= damage;
                player.GetComponent<Player>().nagetiveHealth();
                player.GetComponent<Player>().invincableTimer = player.GetComponent<Player>().invincableTime;
                immuinty.GetComponent<Theimmunity>().invincable = true;
            }
           
        }
    }

}
