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
        transform.GetComponent<BoxCollider>().enabled = false;
    }

    private void Update()
    {
        _time += Time.deltaTime;

        if (_time >= 0.2f && transform.CompareTag("Bullet"))
        {
            Destroy(transform.gameObject);
        }
            
        
        if (_time >= 3f)
        {
            _time = 0;
            explosion.SetActive(true);
            transform.tag = "Bullet";
            transform.GetComponent<BoxCollider>().enabled = true;

        }
        
        
        
            
           




    }
}
