using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LevelObject : MonoBehaviour
{
    [SerializeField] Image[] stars;
    public Button button;
    public GameObject lockIcon;

    public void SetStars(int starNum)
    {
        for (int i = 0; i < starNum; i++)
        {
            stars[i].GetComponent<Image>().color = new Color32(255,255,225,255);
        }
    }
}
