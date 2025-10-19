using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FrontBulletBehaviour : MonoBehaviour
{
    private Rigidbody _rb;
    private float _speed = 2f;
    private void OnEnable()
    {
        _rb = transform.GetComponent<Rigidbody>();
        _rb.velocity = new Vector2(0, -1) * _speed;
    }
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
            Destroy(transform.gameObject);
    }

}
