using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MenuAnimation : MonoBehaviour
{
    public GameObject background;
    public GameObject[] buttons;
    public bool isOpening;
    
    void OnEnable()
    {
        isOpening = true;
        background.GetComponent<Image>().DOFade(0.3f, 0.5f)
        .OnComplete(() =>
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<Image>().DOFade(1f, 0.5f)
                .OnComplete(() =>
                {
                    isOpening = false;
                });
            }
        });

    }

    void OnDisable()
    {
        background.GetComponent<Image>().DOFade(0f, 0.5f)
        .OnComplete(() =>
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<Image>().DOFade(0f, 0.5f)
                .SetDelay(i * 0.2f);
            }
        });
    }
}
