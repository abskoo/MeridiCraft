using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public static gameManager instanet;
    public GameObject plaer;
    private Scene currentscene;
    private GameObject checkPlayer;
    public GameObject Det;

    
    public Text ConinText;
    public int CoinDimonad;




    

    
    

    // Update is called once per frame
    void Start()
    {
        
        currentscene = SceneManager.GetActiveScene();
        checkPlayer = GameObject.FindGameObjectWithTag("Player");
        if (checkPlayer == null && currentscene.name != "Preload")
        {
            Instantiate(plaer, new Vector3(0f, 1f, 0f), Quaternion.identity);
        }
        
        instanet = this;
       
       
        UpdateCollectables();

    }
    private void Update()
    {

    }

    //public void UpdateHealth()
    //{
    //    plaer.GetComponent<Player>().nagetiveHealth();
    //}
    

       
    
    public void TakeDamage(int DamageTotake)
    {
     

    }
    public void CollectCoin(int value)
    {
        CoinDimonad += value;
  
        UpdateCollectables();

    }
    public void spendcoin(int value)
    {
        CoinDimonad -= value;
        UpdateCollectables();

    }
    public void UpdateCollectables()
    {
        ConinText.text = CoinDimonad.ToString();
    }
    
    
    

}
