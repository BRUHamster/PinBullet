using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] GameObject menu;

    void OnEnable()
    {
        if (menu == null)
            Debug.Log("Menu is not attached to Button");

    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Pausemanager();

            menu.SetActive(!menu.activeSelf);
        }
    }

    void OpenMenu()
    {
        menu.SetActive(true);
    }
    
    

    private void Pausemanager() => Time.timeScale = 1 - Time.timeScale;





}
