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
        transform.rotation = Quaternion.FromToRotation(Vector3.right, _direction);
        
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = _direction * _speed;

        float angle = Mathf.Atan2(_direction.y, _direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle - 90);
    }
}