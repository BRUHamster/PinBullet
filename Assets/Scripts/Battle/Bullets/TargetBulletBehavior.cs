using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class TargetBulletBehavior : Bullet
{
    private Vector2 _direction;
    
    void OnEnable()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        
        _direction =  player.transform.position - transform.position;
        _direction.Normalize();
        
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = _direction * _speed;
    }
}