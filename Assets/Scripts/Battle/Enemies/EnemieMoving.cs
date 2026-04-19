using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Numerics;
using UnityEngine.UIElements;
using System.Linq.Expressions;
using Vector3 = UnityEngine.Vector3;

public class EnemieMoving : MonoBehaviour
{

    public GameObject[] points;

    private int _counter = 0;
    private int _point;
    [SerializeField]private bool _isMoving = false;
    private Rigidbody2D _rb2D;
    [SerializeField]private Vector3 target;
    public Tweener moving;
    //void Start() => Debug.Log($"length {points.Length}");

    void OnEnable()
    {
        _rb2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (points.Length == 0) return;

        if (transform.position != points[_counter].transform.position && !_isMoving)
        {
            
            _isMoving = true;
            moving = transform.DOMove(points[_counter].transform.position, 5f)
                .OnComplete(() =>
                {
                    Debug.Log($"Point {_point} got");
                    _isMoving = false;
                });
            _point = _counter;
            _counter++;
            if (_counter > points.Length-1) _counter = 0;
            Debug.Log($"go to Point {_point-1} Counter {_counter}");
        }

    }

    
    
    
}
