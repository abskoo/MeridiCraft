using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZombiePath : MonoBehaviour
{
    public GameObject immunty;
    public GameObject play;
    public float Damage;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D Other)
    {
        if (Other.tag == "Player")
        {
            if (immunty.GetComponent<Theimmunity>().invincable == false)
            {
                play.GetComponent<Player>().currnetHealth -= Damage;
                play.GetComponent<Player>().nagetiveHealth();
                play.GetComponent<Player>().invincableTimer = play.GetComponent<Player>().invincableTime;
                immunty.GetComponent<Theimmunity>().invincable = true;

            }

        }
}

}
