using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class END : MonoBehaviour
{

    public void OnTriggerStay2D(Collider2D Other)
    {
        if (Other.CompareTag("Player"))
        {
            Nextlevel();
        }

    }

    //void Unlocklevel()
    //{
    //    if (SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
    //    {
    //        PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
    //        PlayerPrefs.SetInt("UnlockLevel", PlayerPrefs.GetInt("UnlockLevel", 1) + 1);
    //        PlayerPrefs.Save();
    //    }
    //}


    public void Nextlevel()
    {
        PlayerPrefs.SetInt("current_level", PlayerPrefs.GetInt("current_level") + 1);
        if (PlayerPrefs.GetInt("current_level") > PlayerPrefs.GetInt("Max_level")) PlayerPrefs.SetInt("Max_level", PlayerPrefs.GetInt("Max_level") + 1);
        {
            SceneManager.LoadScene("Level 1");
        }
    }


    

}
