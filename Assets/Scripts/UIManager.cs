using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Image fillImage;
    [SerializeField] float animationDuration;
    void Update()
    {
        
    }

    public void TestButton()
    {
        Debug.Log("It works!");
    }

    public void UpdateDailyBonusProgress(float targetValue)
    {
        DOTween.To(() => fillImage.fillAmount, x => fillImage.fillAmount = x, targetValue, animationDuration);
    }
}
