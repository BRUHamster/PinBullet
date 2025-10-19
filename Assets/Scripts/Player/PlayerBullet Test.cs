using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBulletTest : MonoBehaviour
{

    private int health;
    void Start()
    {
        health = transform.GetComponent<PlayerMovementScript>().health;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        if (other.CompareTag("Bullet"))
        {
            if (health > 0)
                health--;
            else
            {
                SceneManager.LoadScene("Test Menu");
            }
            
        }
    }
}
