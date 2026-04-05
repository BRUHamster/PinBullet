using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemieMoving : MonoBehaviour
{

    public GameObject[] points;

    private int _counter = 0;
    private int _point;
    private bool _isMoving = false;
    

    void Start() => Debug.Log($"length {points.Length}");
    void Update()
    {
        if (points.Length == 0) return;

        if (transform.position != points[_counter].transform.position && !_isMoving)
        {
            
            _isMoving = true;
            transform.DOMove(points[_counter].transform.position, 5f);
            _point = _counter;
            _counter++;
            if (_counter > points.Length-1) _counter = 0;
            Debug.Log($"go to Point {_counter} Counter {_counter}");
        }

        if (transform.position == points[_point].transform.position && _isMoving)
        {
            Debug.Log($"Point1 {_point} Counter {_counter}");
            _isMoving = false;
            
        }
    }
    
    
}
