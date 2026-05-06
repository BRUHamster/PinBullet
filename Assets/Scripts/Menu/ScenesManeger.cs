using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManeger : MonoBehaviour
{
    [SerializeField] public string TargetScene;

    void OnEnable() => Time.timeScale = 1f;
    
    public void StartScene()
    {
        if (TargetScene == "null")
        {
            Application.Quit();
            return;
        }
            

        SceneManager.LoadScene(TargetScene);
    }

    
}
