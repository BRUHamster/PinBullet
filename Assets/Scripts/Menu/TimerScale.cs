using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class TimerScale : MonoBehaviour
{
    private float _time;
    public float roundTime = 10f;

    public event Action TimeOut;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (roundTime <= 0) TimeOut?.Invoke();
        
        _time += Time.deltaTime;

        if (_time >= 1f) //timerScaling
        {
            roundTime--;
            gameObject.GetComponent<TMP_Text>().text = roundTime.ToString();
            _time = 0f;
        }
        
        
    }
}
