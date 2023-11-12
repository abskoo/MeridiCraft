using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class END : MonoBehaviour
{
    public int NUmber_Scene;
    public void OnTriggerStay2D(Collider2D Other)
    {
        if(Other.CompareTag("Player"))
        {
            SceneManager.LoadScene(NUmber_Scene);
            Unlocklevel();
        }

    }

    void Unlocklevel()
    {
        PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("UnlockLevel", PlayerPrefs.GetInt("UnlockLevel", 1) + 1);
        PlayerPrefs.Save();
    }
    


    

}
