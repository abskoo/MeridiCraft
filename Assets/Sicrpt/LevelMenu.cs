using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    public Button[] buttons;
    

    private void Awake()
    {
        int unlockLevel = PlayerPrefs.GetInt("UnlockLevel", 1);
        for(int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
            if(i <= unlockLevel)
                buttons[i].transform.GetChild(1).gameObject.SetActive(false);
            
        }
        for(int i = 0; i < unlockLevel; i++)
        {
            buttons[i].interactable = true;
            buttons[i].transform.GetChild(1).gameObject.SetActive(false);
        }
    }


    public void OpenLevel(int LevelId)
    {
        string levelName = "Livel " + LevelId;
        SceneManager.LoadScene(levelName);
    }
}
