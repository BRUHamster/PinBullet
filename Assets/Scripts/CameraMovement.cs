using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraMovement : MonoBehaviour
{

    public void OnEnable()
    {
        
    }
    
    

    public void Shake()
    {
        //Debug.Log("Shaking");
        StartCoroutine(Shaking());
    }
    IEnumerator Shaking()
    {
        //transform.DOShakeRotation(0.2,5,2,90,true);
        transform.DOShakeRotation(0.5f,0.1f);
        yield break;
    }
}
