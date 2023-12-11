using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimonadCoin : MonoBehaviour
{
    public GameObject player;
    public bool isCoine;
    public bool isEdible;

    public int CoineValue;

    
    

    
    
        
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            
            if (isCoine)
            {
                gameManager.instanet.CoinDimonad += CoineValue;
                gameManager.instanet.UpdateCollectables();
                Destroy(gameObject);
                
            }
            //if(isEdible)
            //{
            //   player.GetComponent<Player>().currnetHealth += HealAmount;
               
            //   Destroy(gameObject);
            //}
        }
        
    }
}
