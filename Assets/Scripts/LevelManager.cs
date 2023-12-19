using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public LevelObject[] levelObjects;
    public static int unlockedLevels;
    public static int currentLevel;
    public const int STARS_FOR_COMPLETION = 3;

    void Start()
    {
        unlockedLevels = PlayerPrefs.GetInt("unlockedLevels", 0);
        UnlockLevels();
    }

    void UnlockLevels()
    {
        for (int i = 0; i < levelObjects.Length; i++)
        {
            if (unlockedLevels >= i)
            {
                levelObjects[i].button.interactable = true;
                levelObjects[i].lockIcon.SetActive(false);
                int stars = PlayerPrefs.GetInt("stars" + i.ToString(), 0);
                levelObjects[i].SetStars(stars);
            }
        }
    }
    
    public void LoadLevel(int lvl)
    {
        //SceneManager.LoadScene(lvl);
        currentLevel = lvl;
    }

    public void OnLevelComplete()
    {
        if (currentLevel == unlockedLevels + 1)
        {
            unlockedLevels++;
            PlayerPrefs.SetInt("stars" + (currentLevel - 1), STARS_FOR_COMPLETION);
            PlayerPrefs.SetInt("unlockedLevels", currentLevel);
            UnlockLevels();
        }
    }
}
