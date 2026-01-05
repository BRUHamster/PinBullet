using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash  : MonoBehaviour
{   
    private PlayerMovementScript _player;
    private float _time;
    private BoxCollider2D _collider;

    private bool _isDashing = false;
    
    
    void OnEnable()
    {
        _collider = GetComponent<BoxCollider2D>();
        _player    = GetComponent<PlayerMovementScript>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            StartCoroutine(Dashing());
    }

    IEnumerator Dashing()
    {
        _isDashing = true;
        transform.gameObject.tag = "Attack";
        _player.moveSpeed *= 1.5f;
        _collider.enabled = false;
        
        yield return new WaitForSeconds(0.3f);
        
        _collider.enabled = true;
        _player.moveSpeed /= 1.5f;
        transform.gameObject.tag = "Player";
        _isDashing = false; 
    }

    public bool GetDash() => _isDashing;
    
}
