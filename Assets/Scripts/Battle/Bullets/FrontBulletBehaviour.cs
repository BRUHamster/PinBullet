using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Object = UnityEngine.Object;

public class FrontBulletBehaviour : Bullet
{
    public Vector2 direction;
    
    private void OnEnable()
    {
        if (direction == Vector2.zero)
        
            Object.Destroy(transform);
        
            
        _rb = transform.GetComponent<Rigidbody2D>();
        _rb.velocity = direction * _speed;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle - 90);

    }
    
    
    

}
