using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    private float _speed;
    private Rigidbody2D _rb;
    private Vector2 _velocity;
    
    // Basic Player Movemnt script
    void OnEnable()
    {
        transform.position = new Vector3(4, 0, -1);
        _speed = 0.1f;
        _rb = GetComponent<Rigidbody2D>();
        _velocity = new Vector2(0, 0);
    }

    void Update()
    {
        _velocity.x = Input.GetAxis("Horizontal") * _speed;
        _velocity.y = Input.GetAxis("Vertical") * _speed;
        
        
    }
    
    void FixedUpdate()
    
    {
        _rb.MovePosition(_rb.position + _velocity);
    }
    
    
}
