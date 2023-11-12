using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    public int damage;
    public GameObject eckule;
    void Start()
    {
       // damage = eckule.GetComponent<gameManager>().damage;
    }

    private void OnTriggerStay2D(Collider2D Other)
    {
        if(Other.tag == "Enemy")
        {
            Other.GetComponent<EnemyToyal>().TakeDamage(damage);
        }

     }
}
