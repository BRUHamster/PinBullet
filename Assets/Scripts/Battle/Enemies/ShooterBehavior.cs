using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class ShooterBehavior : MonoBehaviour
{

    private float _time;
    private Transform _transform1;

    [SerializeField] private Vector3 _point1;
    [SerializeField] private Vector3 _point2;

    [SerializeField] private GameObject _bullet;
    // Start is called before the first frame update
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

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        //moving
        Vector3 position = _transform1.position;
        
        
        if (position == _point1)
            transform.DOMove(_point2, 3f);
        if (position == _point2)
            transform.DOMove(_point1, 3f);
        
        //shooting
        if (_time >= 1f)
        {
            Instantiate(_bullet, _transform1.position, _transform1.rotation);
            _time = 0f;
            
        }
        //
        
    }

    
}
