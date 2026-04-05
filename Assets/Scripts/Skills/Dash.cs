using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Dash  : MonoBehaviour
{   
    
    [SerializeField]public float scale = 5f;

    private PlayerMovementScript _player;
    private float _time = 0.3f;
    //private BoxCollider2D _collider;

    private bool _isDashing = false;
    
    
    
    void OnEnable()
    {
        //_collider = GetComponent<BoxCollider2D>();
        _player    = GetComponent<PlayerMovementScript>();
        transform.localScale = new Vector3(scale, scale, 1);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            StartCoroutine(Dashing());
    }

    IEnumerator Dashing()
    {
        _isDashing = true;
        //transform.gameObject.tag = "Attack";
        _player.moveSpeed *= 1.5f;
        //_collider.enabled = false;
        
        //transform.localScale = new Vector3(scale * 0.9f, scale * 0.9f, 1);
        
        transform.DOScale(scale*0.9f, _time/2);
        yield return new WaitForSeconds(_time);
        transform.DOScale(scale/0.9f, _time/2);

        transform.localScale = new Vector3(scale, scale, 1);
        //_collider.enabled = true;
        _player.moveSpeed /= 1.5f;
        //transform.gameObject.tag = "Player";
        _isDashing = false; 
    }

    public bool IsDashing() => _isDashing;
    
}
