using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    public Button[] buttons;
    public GameObject levelButtons;




    private void Awake()
    {
        ButtonsToArray();
        int unlockLevel = PlayerPrefs.GetInt("UnlockLevel", 1);
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
            //buttons[i].transform.GetChild(1).gameObject.SetActive(true);
            if (i <= unlockLevel)
            {
                buttons[i].transform.GetChild(1).gameObject.SetActive(true);
               



            }
         


        }


        for (int i = 0; i < unlockLevel; i++)
        {
            buttons[i].interactable = true;
            buttons[i].transform.GetChild(1).gameObject.SetActive(false);
           



        }
    }



    public void Openlevel(int levelId)
    {
        string levelName = "Level " + levelId;
        SceneManager.LoadScene(levelName);

    }

    public void DeleteLevel()
    {
        PlayerPrefs.DeleteAll();
    }

    void ButtonsToArray()
    {
        int childCount = levelButtons.transform.childCount;
        buttons = new Button[childCount];

        for (int i = 0; i < childCount; i++)
        {
            buttons[i] = levelButtons.transform.GetChild(i).gameObject.GetComponent<Button>();

        }
    }



}






























//{
//    public Button[] buttons;
    

//    private void Awake()
//    {
//        int unlockLevel = PlayerPrefs.GetInt("unlockLevel",1);
//        for (int i = 0; i < buttons.Length; i++)
//        {
//            buttons[i].interactable = false;
//            //buttons[i].transform.GetChild(1).gameObject.SetActive(true);
//            if (i <= unlockLevel)
//            {
//                buttons[i].transform.GetChild(1).gameObject.SetActive(true);
//            }
//        }

//        for (int i = 0; i < unlockLevel; i++)
//        {
//            buttons[i].interactable = true;
//            buttons[i].transform.GetChild(1).gameObject.SetActive(false);
//        }
//    }
////    buttons[i].transform.GetChild(1).gameObject.SetActive(false);
////                    if(i <= unlockLevel)
////                        buttons[i].transform.GetChild(1).gameObject.SetActive(false);

////                }
////for (int i = 0; i < unlockLevel; i++)
////{
////    buttons[i].interactable = true;
////    buttons[i].transform.GetChild(1).gameObject.SetActive(false);
////}
////            }


//       public void OpenLevel(int LevelId)
//    {
//        string levelName = "Level " + LevelId;
//        SceneManager.LoadScene(levelName);
//    }

//    public void ClearPlayerPrefs()
//    {
//        PlayerPrefs.DeleteAll();
//        Debug.Log("PlayerPrefs data cleared.");
//    }

