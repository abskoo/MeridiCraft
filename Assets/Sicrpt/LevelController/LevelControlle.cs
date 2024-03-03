using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelControlle : MonoBehaviour
{
    public int Level = 1;
    public List<Button> levelButtons = new List<Button>();

    private void Start()
    {
        UpdateLevel(Level);
    }

    public void UpdateLevel(int levelNumber)
    {
        ColorBlock unlockedColor = levelButtons[0].colors;

        for (int i = 0; i < levelButtons.Count; i++)
        {
            if(i <= levelNumber)
            {
                levelButtons[i].interactable = true;
                levelButtons[i].colors = unlockedColor;

            }
            else
            {
                levelButtons[i].interactable = false;
                //Button colors
                ColorBlock lockedColor = levelButtons[0].colors;
                lockedColor.disabledColor = Color.gray; // يمكنك تعيين اللون الرمادي هنا
                levelButtons[i].colors = lockedColor;
            }
        }
    }

}
