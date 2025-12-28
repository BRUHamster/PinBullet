using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Resume()
    {
        UnpauseGame();
        gameObject.SetActive(false);
    }

    public void Exit() => SceneManager.LoadScene("Test Menu");
    
        
    
    private void UnpauseGame() => Time.timeScale = 1f;
}
