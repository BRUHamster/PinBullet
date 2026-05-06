using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MenuAnimation : MonoBehaviour
{
    public GameObject line;

    public GameObject background;
    public GameObject background2;
    public GameObject[] buttons;
    public GameObject PauseText;
    public bool isOpening;

    private float _time;
    
    void OnEnable()
    {
        _time = 0;
        isOpening = true;


        AtoZero(PauseText);
        AtoZero(background2);
        foreach (var button in buttons)
        {
            AtoZero(button);
        }
    }

    void Update()
    {
        _time += Time.unscaledDeltaTime;
        
        if (_time >= 0.25f)
        {
            Debug.Log("Time got");
            TextAppearance(PauseText);
            background2.GetComponent<Image>().DOFade(1f, 0.5f).SetUpdate(true);
            foreach (var button in buttons)
            {
                TextAppearance(button);
            }
        }
    }


    void OnDisable()
    {

    }
    
    public void MenuClose()
    {
        line.GetComponent<Animator>().SetTrigger("Close");
        TextDisappearance(PauseText);
        background2.GetComponent<Image>().DOFade(0f, 0.5f).SetUpdate(true);
    }

    void TextAppearance(GameObject text)
    {
        text.GetComponent<Image>().DOFade(1, 0.5f).SetUpdate(true);
    }
    void TextDisappearance(GameObject text)
    {
        text.GetComponent<Image>().DOFade(0, 0.5f).SetUpdate(true);
    }
    void AtoZero(GameObject obj)
    {
        var color = obj.GetComponent<Image>().color;
        obj.GetComponent<Image>().color = new Color(color.r, color.g, color.b, 0f);
    }
}
