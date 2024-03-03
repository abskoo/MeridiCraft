using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class END : MonoBehaviour
{
    public GameObject Won;
    

    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.CompareTag("Player"))
        {

            Unlocklevel();
            Won.SetActive(true);
            
 
        }
    }

    void Unlocklevel()
    {
        if (SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
        {
            PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("UnlockLevel", PlayerPrefs.GetInt("UnlockLevel", 1) + 1);
            PlayerPrefs.Save();
        }
    }

    public void ClickNext()
    {
        SceneController.instance.NextLevel();
    }

    
}






