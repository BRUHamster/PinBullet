using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public short owner;

    protected float _speed = 2f;
    protected Rigidbody2D _rb;

    [SerializeField]private GameObject _destroyEffect;

     //0 - enemie: 1-player
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            //Instantiate(_destroyEffect, transform.position, transform.rotation);
            Destroy(transform.gameObject);
            
        }
    }

    public void SetOwner(short _owner)
    {
        owner = _owner;
    }
    
}
