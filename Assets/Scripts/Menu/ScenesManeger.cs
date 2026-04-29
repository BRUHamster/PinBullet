using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManeger : MonoBehaviour
{
    void OnEnable() => Time.timeScale = 1f;
    
    public void StartTest()
    {
        //SceneManager.LoadScene("Test Level");
    }

    
}
