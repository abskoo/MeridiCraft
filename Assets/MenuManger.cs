using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManger : MonoBehaviour
{
    public GameObject Levels_panal;

    public GameObject[] Levels;

    int MaxiMum_level = 1;

    public object SceneManger { get; private set; }

    void Start()
    {
        if(PlayerPrefs.HasKey("Max_level"))
        {
            MaxiMum_level = PlayerPrefs.GetInt("Max_level");
        }
        else
        {
            PlayerPrefs.SetInt("Max_level", 1);
        }

        for(int i = 1; i <= Levels.Length; i++)
        {
            if (i <= MaxiMum_level)
            {
                Levels[i - 1].transform.GetChild(1).gameObject.SetActive(false);
            }
            else
            {
                Destroy(Levels[i - 1].transform.GetComponent<Button>());
            }
        }
        
    }

   
    void Update()
    {
        
    }

    public void GoToGame(int level_Number)
    {
        PlayerPrefs.SetInt("current_level", level_Number);
        SceneManager.LoadScene("Level 1");

    }
}
