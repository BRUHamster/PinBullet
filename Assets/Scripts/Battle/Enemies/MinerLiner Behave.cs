using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class MinerLinerBehave : EnemyBehaviour
{
    [SerializeField]private GameObject _mine;
    [SerializeField]private float _speed = 3f;
    [SerializeField]private float _attackRange = 5f;
    private GameObject _target;
    private Rigidbody2D _rb2D;
    private bool _isAttacking = false;

    float x;
    float y;
    float oldSpeed;
    float dir;


    void OnEnable()
    {
        _target = GameObject.FindGameObjectWithTag("Player");
        _rb2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Math.Round(transform.position.x,1)  ==  Math.Round(_target.transform.position.x,1) )
        {
            if (!_isAttacking) 
                StartCoroutine(AttackV());

        }

        if  (Math.Round(transform.position.y,1)  ==  Math.Round(_target.transform.position.y,1))
        {
            
            if (!_isAttacking) 
                StartCoroutine(AttackH());
            
        }


        
    }

    IEnumerator AttackV()
    {
        _isAttacking = true;
        DOTween.Pause(transform);

        x = transform.position.x;
        y = transform.position.y;
        oldSpeed = _speed;

        yield return new WaitForSeconds(0.4f);
        dir = sign(transform.position.y - _target.transform.position.y);

        for (int i = 1; i <= _attackRange; i++)
        {
            Instantiate(_mine, new Vector3(x, y - _speed * dir, 0), Quaternion.Euler(0,0,0));
            _speed += oldSpeed;
            yield return new WaitForSeconds(0.3f);
        }

        _speed = oldSpeed;

        DOTween.Play(transform);
        _isAttacking = false;
    }

    IEnumerator AttackH()
    {
        _isAttacking = true;
        DOTween.Pause(transform);

        x = transform.position.x;
        y = transform.position.y;
        oldSpeed = _speed;

        yield return new WaitForSeconds(0.4f);
        dir = sign(transform.position.x - _target.transform.position.x);

        for (int i = 1; i <= _attackRange; i++)
        {
            Instantiate(_mine, new Vector3(x - _speed * dir, y, 0), Quaternion.Euler(0,0,0));
            _speed += oldSpeed;
            yield return new WaitForSeconds(0.3f);
        }
        
        _speed = oldSpeed;
        
        DOTween.Play(transform);
        _isAttacking = false;
    }

    float sign(float value)
    {
        if (value > 0)
            return 1;
        else 
            return -1;
    }
    


}
