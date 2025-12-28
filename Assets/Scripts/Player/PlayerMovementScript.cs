using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.Serialization;

public class PlayerMovementScript : MonoBehaviour
{
    

    private Rigidbody2D _rb;
    public float moveSpeed = 5.0f;
    

    void OnEnable()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        _rb.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed; 
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        //GetComponent<SpriteRenderer>().color = collision.gameObject.GetComponent<SpriteRenderer>().color;
        
        
        
        _rb.AddForce (Vector2.left * 10f, ForceMode2D.Impulse);
    }
}
