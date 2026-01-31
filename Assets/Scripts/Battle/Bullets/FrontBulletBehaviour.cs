using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FrontBulletBehaviour : Bullet
{
    private void OnEnable()
    {
        _rb = transform.GetComponent<Rigidbody2D>();
        _rb.velocity = new Vector2(1, 0) * _speed;
    }
    
    

}
