using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    protected float _speed = 2f;
    protected Rigidbody2D _rb;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
            Destroy(transform.gameObject);
    }

    
}
