using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respone : MonoBehaviour
{
    public int Respon;
    public GameObject player;

   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        Response();
    }
    
    public void Response()
    {
        if(player.GetComponent<Player>().currnetHealth == 0)
        {
            
            SceneManager.LoadScene(Respon);

        }
        
    }


}
