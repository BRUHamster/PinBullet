using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class ShooterBehavior : EnemyBehaviour
{
    
    
    private float _time;
    

    [SerializeField] private GameObject _bullet;
    
    void OnEnable()
    {
        _transform1 = transform;
        if (_point1 == null)
            _point1 = transform.position;

        if (_point2 == null)
            _point2 = transform.position;
        
        
        Debug.Log($"{_point1} + {_point2} ");
        transform.DOMove(_point1, 1.5f);
    }

    
    void Update()
    {
        if (isFrozen) return; 
        
        _time += Time.deltaTime;
        
        //shooting
        if (_time >= 1f && !isFrozen)
        {
            Instantiate(_bullet, _transform1.position, _transform1.rotation);
            _time = 0f;
            
        }
    }
    

    
}
