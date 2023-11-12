using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public float Damage;
    public GameObject DamageLava;
    
    private void Start()
    {
        if(GetComponent<EnemyToyal>())
        {
            Damage = GetComponent<EnemyToyal>().Damage;
            
        }else if(GetComponentInParent<EnemyToyal>())
        {
            Damage = GetComponentInParent<EnemyToyal>().Damage;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            //gameManager.instanet.TakeDamage(Damage);
            DamageLava.GetComponent<Player>().currnetHealth -= Damage;
            DamageLava.GetComponent<Player>().nagetiveHealth();
        }        
    }
}
