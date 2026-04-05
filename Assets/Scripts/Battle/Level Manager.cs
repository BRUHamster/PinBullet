using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public float roundTime;
    
    [SerializeField] private GameObject _timer;
    [SerializeField] private GameObject _loseMenu;
    [SerializeField] private GameObject _winMenu;

    private float _time = 0f;

    void Start()
    {
        _timer.GetComponent<TimerScale>().roundTime = roundTime;
        _timer.GetComponent<TimerScale>().TimeOut += Wining;
        GameObject.FindGameObjectWithTag("Player").GetComponent<DamageTaker>().Death += Losing;
    }
    
    

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;

        if (_time >= 1f) 
        {
            
        }
    }

    void Wining() => _winMenu.SetActive(true);
    
    void Losing() => _loseMenu.SetActive(true);
    
    
}
