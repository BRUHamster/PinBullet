using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class TargetBulletBehavior : MonoBehaviour
{
    private float _speed = 2f;
    private Vector2 _direction;
    private Rigidbody _rb;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        
        _direction =  player.transform.position - transform.position;
        _direction.Normalize();
        _rb = GetComponent<Rigidbody>();
        
        _rb.velocity = _direction * _speed;
    }

    private void Update()
    {
        if (transform.position.y <= -6)
            Destroy(transform.gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
            Destroy(transform.gameObject);
    }
    

    
}
