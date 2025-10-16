using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class BulletBehavior : MonoBehaviour
{
    private float _speed = 2f;
    private Vector2 _direction;
    private Rigidbody2D _rb;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        
        _direction =  player.transform.position - transform.position;
        _direction.Normalize();
        _rb = GetComponent<Rigidbody2D>();
        
        _rb.velocity = _direction * _speed;
    }

    void OnTriggerEnter2D(Collider2D other) => Destroy(transform.gameObject);
    

    
}
