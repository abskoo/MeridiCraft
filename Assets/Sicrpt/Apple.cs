using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public GameObject player;
    public float Heal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D Other)
    {
        if(Other.tag == "Player")
        {
            player.GetComponent<Player>().currnetHealth += Heal;
            player.GetComponent<Player>().nagetiveHealth();
            Destroy(gameObject);
        }
    }
}
