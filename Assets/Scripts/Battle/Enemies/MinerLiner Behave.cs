using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class MinerLinerBehave : EnemyBehaviour
{
    [SerializeField]private GameObject _mine;
    private GameObject _target;
    private Rigidbody2D _rb2D;
    private bool _isAttacking = false;

    void OnEnable()
    {
        _target = GameObject.FindGameObjectWithTag("Player");
        _rb2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Math.Round(transform.position.x,1)  ==  Math.Round(_target.transform.position.x,1) )
        {
            //Debug.Log("Attack");
            if (!_isAttacking) 
            {
                StartCoroutine(Attack());
            }
        }


        
    }

    IEnumerator Attack()
    {
        _isAttacking = true;
        DOTween.Pause(transform);

        float x = transform.position.x;
        float y = transform.position.y;

        yield return new WaitForSeconds(0.4f);

        Instantiate(_mine, new Vector3(x, y - 3f, 0), Quaternion.Euler(0,0,0));
        yield return new WaitForSeconds(0.3f);

        Instantiate(_mine, new Vector3(x, y - 6f, 0), Quaternion.Euler(0,0,0));
        yield return new WaitForSeconds(0.3f);
        

        DOTween.Play(transform);
        _isAttacking = false;

    }


}
