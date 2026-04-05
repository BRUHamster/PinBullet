using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mine : MonoBehaviour
{
    private float _time;
    [SerializeField] public GameObject explosion;
    

    private void OnEnable()
    {
        _time = 0;
        transform.GetComponent<BoxCollider2D>().enabled = false;
        
    }

    private void Update()
    {
        _time += Time.deltaTime;

        if (_time >= 0.5f && transform.CompareTag("Bullet"))
        {
            Destroy(transform.gameObject);
        }
        
        if (_time >= 3f)
        {
            _time = 0;
            explosion.SetActive(true);
            transform.tag = "Bullet";
            transform.GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("Main Camera").GetComponent<CameraMovement>().Shake();

        }
        
    }

    
    
}
